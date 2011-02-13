// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.5.0.0
//      Runtime Version:4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace TechTalk.SpecFlow.FeatureTests.StepArgumentTransfomation
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.5.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Step Argument Transformations")]
    public partial class StepArgumentTransformationsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "StepArgumentTransformation.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Step Argument Transformations", "In order to reduce the amount of code and repetitive tasks in my steps\r\nAs a prog" +
                    "rammer\r\nI want to define reusable transformations for my step arguments", GenerationTargetLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Steps with non-string arguments")]
        public virtual void StepsWithNon_StringArguments()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Steps with non-string arguments", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("Dan has been registered at date 2003/03/13");
#line 8
 testRunner.And("Aslak has been registered at terminal 2");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Origin",
                        "Destination",
                        "Departure Date"});
            table1.AddRow(new string[] {
                        "Hull",
                        "Anywhere else",
                        "2011/01/01"});
#line 9
 testRunner.And("Bob has booked a flight", ((string)(null)), table1);
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Multi-line text arguments can be converted to non-string step parame")]
        public virtual void Multi_LineTextArgumentsCanBeConvertedToNon_StringStepParame()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Multi-line text arguments can be converted to non-string step parame", ((string[])(null)));
#line 13
this.ScenarioSetup(scenarioInfo);
#line 14
 testRunner.Given("I have a step binding with an XmlDocument parameter");
#line 15
 testRunner.And("a step argument converter from string to XmlDocument");
#line hidden
#line 16
 testRunner.When("a step is executed that macthes to the binding with a long XML argument", "\t<Root>\r\n\t\t<Child attr=\"value\" />\r\n\t</Root>", ((TechTalk.SpecFlow.Table)(null)));
#line 22
 testRunner.Then("the parsed XML is passed to the step binding");
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion
