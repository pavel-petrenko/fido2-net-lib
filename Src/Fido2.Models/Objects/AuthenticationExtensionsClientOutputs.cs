﻿using System.Text.Json.Serialization;

namespace Fido2NetLib.Objects;

public class AuthenticationExtensionsClientOutputs
{
    /// <summary>
    /// This extension allows for passing of conformance tests
    /// </summary>
    [JsonPropertyName("example.extension.bool")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? Example { get; set; }

    /// <summary>
    /// This extension allows WebAuthn Relying Parties that have previously registered a credential using the legacy FIDO JavaScript APIs to request an assertion.
    /// https://www.w3.org/TR/webauthn/#sctn-appid-extension
    /// </summary>
    [JsonPropertyName("appid")]
    public bool AppID { get; set; }

    /// <summary>
    /// This extension enables the WebAuthn Relying Party to determine which extensions the authenticator supports.
    /// https://www.w3.org/TR/webauthn/#sctn-supported-extensions-extension
    /// </summary>
    [JsonPropertyName("exts")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string[]? Extensions { get; set; }

    /// <summary>
    /// This extension enables use of a user verification method.
    /// https://www.w3.org/TR/webauthn/#sctn-uvm-extension
    /// </summary>
    [JsonPropertyName("uvm")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public ulong[][]? UserVerificationMethod { get; set; }

    /// <summary>
    /// This client registration extension facilitates reporting certain credential properties known by the client to the requesting WebAuthn Relying Party upon creation of a public key credential source as a result of a registration ceremony.
    /// </summary>
    [JsonPropertyName("credProps")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public CredentialPropertiesOutput? CredProps { get; set; }

    /// <summary>
    /// This extension allows a Relying Party to evaluate outputs from a pseudo-random function (PRF) associated with a credential.
    /// https://w3c.github.io/webauthn/#prf-extension
    /// </summary>
    [JsonPropertyName("prf")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public AuthenticationExtensionsPRFOutputs? PRF { get; set; }

    /// <summary>
    /// This client registration extension and authentication extension allows a Relying Party to store opaque data associated with a credential.
    /// https://w3c.github.io/webauthn/#sctn-large-blob-extension
    /// </summary>
    [JsonPropertyName("largeBlob")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public AuthenticationExtensionsLargeBlobOutputs? LargeBlob { get; set; }

    /// <summary>
    /// The <c>CredentialProtectionPolicy</c> stored alongside the created credential
    /// https://fidoalliance.org/specs/fido-v2.2-rd-20230321/fido-client-to-authenticator-protocol-v2.2-rd-20230321.html#sctn-credProtect-extension
    /// </summary>
    [JsonPropertyName("credProtect")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public CredentialProtectionPolicy? CredProtect { get; set; }
}
