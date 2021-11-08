using impulso.Debugging;

namespace impulso
{
    public class impulsoConsts
    {
        public const string LocalizationSourceName = "impulso";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "5d909b7aa1dc42d2a031e3eae5a01151";
    }
}
