using System;
using LateBindingApi.Core;
namespace NetOffice.DAOApi.Enums
{
	 /// <summary>
	 /// SupportByVersion DAO 12, 3.6
	 /// </summary>
	[SupportByVersionAttribute("DAO", 12,3.6)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum SetOptionEnum
	{
		 /// <summary>
		 /// SupportByVersion DAO 12, 3.6
		 /// </summary>
		 /// <remarks>6</remarks>
		 [SupportByVersionAttribute("DAO", 12,3.6)]
		 dbPageTimeout = 6,

		 /// <summary>
		 /// SupportByVersion DAO 12, 3.6
		 /// </summary>
		 /// <remarks>57</remarks>
		 [SupportByVersionAttribute("DAO", 12,3.6)]
		 dbLockRetry = 57,

		 /// <summary>
		 /// SupportByVersion DAO 12, 3.6
		 /// </summary>
		 /// <remarks>8</remarks>
		 [SupportByVersionAttribute("DAO", 12,3.6)]
		 dbMaxBufferSize = 8,

		 /// <summary>
		 /// SupportByVersion DAO 12, 3.6
		 /// </summary>
		 /// <remarks>58</remarks>
		 [SupportByVersionAttribute("DAO", 12,3.6)]
		 dbUserCommitSync = 58,

		 /// <summary>
		 /// SupportByVersion DAO 12, 3.6
		 /// </summary>
		 /// <remarks>59</remarks>
		 [SupportByVersionAttribute("DAO", 12,3.6)]
		 dbImplicitCommitSync = 59,

		 /// <summary>
		 /// SupportByVersion DAO 12, 3.6
		 /// </summary>
		 /// <remarks>60</remarks>
		 [SupportByVersionAttribute("DAO", 12,3.6)]
		 dbExclusiveAsyncDelay = 60,

		 /// <summary>
		 /// SupportByVersion DAO 12, 3.6
		 /// </summary>
		 /// <remarks>61</remarks>
		 [SupportByVersionAttribute("DAO", 12,3.6)]
		 dbSharedAsyncDelay = 61,

		 /// <summary>
		 /// SupportByVersion DAO 12, 3.6
		 /// </summary>
		 /// <remarks>62</remarks>
		 [SupportByVersionAttribute("DAO", 12,3.6)]
		 dbMaxLocksPerFile = 62,

		 /// <summary>
		 /// SupportByVersion DAO 12, 3.6
		 /// </summary>
		 /// <remarks>63</remarks>
		 [SupportByVersionAttribute("DAO", 12,3.6)]
		 dbLockDelay = 63,

		 /// <summary>
		 /// SupportByVersion DAO 12, 3.6
		 /// </summary>
		 /// <remarks>65</remarks>
		 [SupportByVersionAttribute("DAO", 12,3.6)]
		 dbRecycleLVs = 65,

		 /// <summary>
		 /// SupportByVersion DAO 12, 3.6
		 /// </summary>
		 /// <remarks>66</remarks>
		 [SupportByVersionAttribute("DAO", 12,3.6)]
		 dbFlushTransactionTimeout = 66,

		 /// <summary>
		 /// SupportByVersion DAO 12
		 /// </summary>
		 /// <remarks>80</remarks>
		 [SupportByVersionAttribute("DAO", 12)]
		 dbPasswordEncryptionProvider = 80,

		 /// <summary>
		 /// SupportByVersion DAO 12
		 /// </summary>
		 /// <remarks>81</remarks>
		 [SupportByVersionAttribute("DAO", 12)]
		 dbPasswordEncryptionAlgorithm = 81,

		 /// <summary>
		 /// SupportByVersion DAO 12
		 /// </summary>
		 /// <remarks>82</remarks>
		 [SupportByVersionAttribute("DAO", 12)]
		 dbPasswordEncryptionKeyLength = 82
	}
}