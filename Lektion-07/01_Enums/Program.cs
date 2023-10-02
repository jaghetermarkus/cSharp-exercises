using _01_Enums.Enums;
using _01_Enums.Service;

var weekdayService = new WeekdayService();
var urlCheckService = new UrlCheckerService();

//weekdayService.Run();

await urlCheckService.Run("https://google.com");