using System.Text.RegularExpressions;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace PlaywrightTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class PracticeTestNest : PageTest
{
    [SetUp]
    public async Task Setup()
    {
        await Page.GotoAsync("https://dungdalaicam08062003.github.io/FrontTestNech/HomePage/homepage.html");
    }
    public async Task HasTitle()
    {
        await Expect(Page).ToHaveURLAsync( new Regex(".*/FrontTestNech/HomePage/homepage.html"));
        await Expect(Page).ToHaveTitleAsync( new Regex("LAPTOP TECHNEST"));
    }
    [Test]
    public async Task ActionOnWebsite()
    {
        await HasTitle();
        await Page.GetByRole(AriaRole.Button, new() { Name = "Thêm giỏ" }).First.ClickAsync();
        await Page.GetByRole(AriaRole.Button, new() { Name = "Thêm giỏ" }).Nth(1).ClickAsync();
        await Page.GetByText("ASUS VivoBook").ClickAsync();
        await Page.Locator("#pdMainImg").ClickAsync();
        await Page.GetByRole(AriaRole.Button, new() { Name = "Thêm vào giỏ" }).ClickAsync();
        await Page.GetByRole(AriaRole.Button, new() { Name = "Ảnh sau" }).ClickAsync();
        await Page.Locator("#pdMainImg").ClickAsync();
        await Page.GetByText("‹ › Mô tả Thông số kỹ thuật CPU Intel Core i5 RAM 8GB Storage 512GB SSD Giá gốc").ClickAsync();
        await Page.GetByRole(AriaRole.Link, new() { Name = "LAPTOP TECHNEST" }).ClickAsync();
        await Page.GetByRole(AriaRole.Textbox, new() { Name = "Tìm kiếm sản phẩm..." }).ClickAsync();
        await Page.GetByRole(AriaRole.Textbox, new() { Name = "Tìm kiếm sản phẩm..." }).FillAsync("dddddddd");
        await Page.GetByRole(AriaRole.Button, new() { Name = "🔍" }).ClickAsync();
        await Page.GetByText("Dell G15 Gaming").ClickAsync();
        await Page.GetByRole(AriaRole.Button, new() { Name = "👤 Tài khoản" }).ClickAsync();
        await Page.GetByRole(AriaRole.Link, new() { Name = "LAPTOP TECHNEST" }).ClickAsync();
        await Page.GetByText("HP Pavilion").ClickAsync();
        await Page.GetByText("‹ › Mô tả Thông số kỹ thuật CPU Ryzen 5 RAM 16GB Giá gốc: -- Giá Sale: 17.000.").ClickAsync();
    }
}