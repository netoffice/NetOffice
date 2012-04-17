using System;
using LateBindingApi.Core;
namespace NetOffice.ExcelApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Excel 10, 11, 12, 14
	 /// </summary>
	[SupportByVersionAttribute("Excel", 10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlCalculatedMemberType
	{
		 /// <summary>
		 /// SupportByVersion Excel 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Excel", 10,11,12,14)]
		 xlCalculatedMember = 0,

		 /// <summary>
		 /// SupportByVersion Excel 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Excel", 10,11,12,14)]
		 xlCalculatedSet = 1
	}
}