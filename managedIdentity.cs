using Azure.Identity;
using Azure.Security.KeyVault.Secrets;

class Program
{
    static async Task Main(string[] args)
    {
        string keyVaultName = "your-keyvault-name";
        string secretName = "your-secret-name";

        // Create a token credential using the managed identity
        ManagedIdentityCredential managedIdentityCredential = new ManagedIdentityCredential();

        // Create a secret client using the token credential
        SecretClient secretClient = new SecretClient(new Uri($"https://{keyVaultName}.vault.azure.net/"), managedIdentityCredential);

        try
        {
            // Retrieve a secret from the Key Vault
            KeyVaultSecret secret = await secretClient.GetSecretAsync(secretName);
            Console.WriteLine($"Secret Value: {secret.Value}");
        }
        catch (RequestFailedException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
