namespace LockstepSDK
{

    /// <summary>
    /// An enumeration listing all publicly available Lockstep Platform environments
    /// </summary>
    public enum LockstepEnv
    {
        /// <summary>
        /// Production environment - https://api.lockstep.io
        /// </summary>
        PRD,

        /// <summary>
        /// Sandbox environment - https://api.sbx.lockstep.io
        /// </summary>
        SBX
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