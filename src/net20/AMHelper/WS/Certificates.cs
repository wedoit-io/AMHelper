using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

public class Certificates
{
    /// <summary>
    /// Ignora eventuali errori causati dall'utilizzo di certificati non validi
    /// </summary>
    public static void IgnoreBadCertificates()
    {
        System.Net.ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);
    }

    /// <summary>
    /// Ritorna sempre true per ignorare errori causati da ceritficati non validi
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="certificate"></param>
    /// <param name="chain"></param>
    /// <param name="policyErrors"></param>
    /// <returns></returns>
    static bool AcceptAllCertifications(object sender,
                                                X509Certificate certificate,
                                                X509Chain chain,
                                                SslPolicyErrors policyErrors)
    {
        //Return True to force the certificate to be accepted.     
        //Needed so that calling web services with self-signed certs will work.
        return true;
    }
}
