// using System.Text.RegularExpressions;
// using System.Threading.Tasks;
// using Microsoft.Playwright;
// using Microsoft.Playwright.NUnit;
// using NUnit.Framework;

// namespace PlaywrightTests;

// [Parallelizable(ParallelScope.Self)]
// [TestFixture]
// public class ExampleTest : PageTest
// {
//     [Test]
//     public async Task HasTitle()
//     {
//         await Expect(Page).ToHaveURLAsync( new Regex(".*/docs/intro"));
//         await Expect(Page).ToHaveTitleAsync(new Regex("Playwright"));
//     }
//     [SetUp]
//     public async Task Setup()
//     {
//         await Page.GotoAsync("https://playwright.dev");
//         await Page.GetByRole(AriaRole.Link, new() {Name = "Get started" }).ClickAsync();
//         await Expect(Page.GetByRole(AriaRole.Heading, new() {Name = "Installation"})).ToBeVisibleAsync();
//     }
// }