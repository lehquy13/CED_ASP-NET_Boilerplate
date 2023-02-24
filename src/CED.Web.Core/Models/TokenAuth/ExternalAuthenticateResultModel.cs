namespace CED.Models.TokenAuth
{
    /// <summary>
    /// template comments
    /// </summary>
    public class ExternalAuthenticateResultModel
    {   /// <summary>
        /// template comments
        /// </summary>
        public string AccessToken { get; set; }
        /// <summary>
        /// template comments
        /// </summary>
        public string EncryptedAccessToken { get; set; }
        /// <summary>
        /// template comments
        /// </summary>
        public int ExpireInSeconds { get; set; }
        /// <summary>
        /// template comments
        /// </summary>
        public bool WaitingForActivation { get; set; }
    }
}
