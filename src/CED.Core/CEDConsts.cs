using CED.Debugging;

namespace CED
{
    public class CEDConsts
    {
        public const string LocalizationSourceName = "CED";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "85c123652f3244c885fa5962eeca337d";
    }
}
