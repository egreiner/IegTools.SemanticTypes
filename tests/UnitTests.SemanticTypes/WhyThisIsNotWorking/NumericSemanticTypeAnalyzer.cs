namespace UnitTests.SemanticTypes.WhyThisIsNotWorking;

using System.Collections.Immutable;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
public class NumericSemanticTypeAnalyzer : DiagnosticAnalyzer
{
    public const string DiagnosticId = "NumericSemanticTypeAnalyzer";

    private static readonly DiagnosticDescriptor Rule = new(
        DiagnosticId,
        "Ensure the same type for TSemanticType",
        "TSemanticType should be the same type as NumericSemanticType<TNumber>",
        "NumericSemanticType",
        DiagnosticSeverity.Error,
        isEnabledByDefault: true);

    public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics => ImmutableArray.Create(Rule);

    public override void Initialize(AnalysisContext context)
    {
        context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);
        context.EnableConcurrentExecution();
        context.RegisterSyntaxNodeAction(AnalyzeNode, SyntaxKind.MethodDeclaration);
    }

    private void AnalyzeNode(SyntaxNodeAnalysisContext context)
    {
        var methodDeclaration = (MethodDeclarationSyntax)context.Node;
        var methodSymbol = context.SemanticModel.GetDeclaredSymbol(methodDeclaration);
        if (methodSymbol == null || !methodSymbol.Name.Equals("Add")) return;

        var containingType = methodSymbol.ContainingType;
        if (!containingType.Name.Equals("NumericSemanticType")) return;

        var typeParameter = methodSymbol.TypeParameters.SingleOrDefault(tp => tp.Name == "TSemanticType");
        if (typeParameter == null) return;

        var constraint = typeParameter.ConstraintTypes.SingleOrDefault(ct => ct is QualifiedNameSyntax qns && qns.Right.Identifier.Text == "NumericSemanticType");
        ////var constraint = typeParameter.ConstraintTypes.SingleOrDefault(ct => ct is DiagnosticId qns && qns.Right.Identifier.Text == "NumericSemanticType");
        if (constraint != null)
        {
            var diagnostic = Diagnostic.Create(Rule, methodDeclaration.GetLocation());
            context.ReportDiagnostic(diagnostic);
        }
    }
}
