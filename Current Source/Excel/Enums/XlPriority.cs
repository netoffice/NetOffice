using System;
using NetOffice;
namespace NetOffice.ExcelApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Excel 9, 10, 11, 12, 14
	 /// </summary>
	[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlPriority
	{
		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>-4127</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		 xlPriorityHigh = -4127,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>-4134</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		 xlPriorityLow = -4134,

		 /// <summary>
		 /// SupportByVersion Excel 9, 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>-4143</remarks>
		 [SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		 xlPriorityNormal = -4143
	}
}