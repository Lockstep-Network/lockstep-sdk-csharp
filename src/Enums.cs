namespace LockstepSDK
{

    /// <summary>
    /// A collection of publicly available Lockstep Platform environments
    /// </summary>
    public class LockstepEnv
    {
        /// <summary>
        /// Production environment - https://api.lockstep.io
        /// </summary>
        public static string PRD = "prd";

        /// <summary>
        /// Sandbox environment - https://api.sbx.lockstep.io
        /// </summary>
        public static string SBX = "sbx";
    }

    /// <summary>
    /// The different depths of describing an account. See the Financial Account Model for possible values for each depth
    /// </summary>
    public enum ReportDepth
    {
        /// <summary>
        /// the classification of the account
        /// </summary>
        Classification = 0,
        
        /// <summary>
        /// the category of the account
        /// </summary>
        Category = 1,
        
        /// <summary>
        /// the subcategory of the account
        /// </summary>
        Subcategory = 2,
        
        /// <summary>
        /// the account
        /// </summary>
        Account = 3
    }
}