# Introduction
Through collaboration between NEHTA and the software industry, Standards Australia published Australian Technical Specification (ATS) 5822 E-Health Secure Message Delivery (SMD) in March 2010.

While SMD supports delivery to a known internet address, the Endpoint Location Service (ELS) allows discovery of the correct delivery address for a healthcare organisation identified by a Healthcare Provider Identifier – Organisation (HPI-O).

# Content
The ELS B2B Client Library simplifies the development process by providing vendors with a sample implementation of how to interact with an ELS Endpoint. The library implements all the available ELS interfaces and operations listed below:

- Lookup
	- listInteractions
	- validateInteraction
- Publish
	- addInteraction
	- removeInteraction

Details of each interface are described and defined in TR5823-2010: Endpoint location service (available from http://www.saiglobal.com/) and further documentation is available on the Agency web site (developer.digitalhealth.gov.au) under Implementation resources>Secure Messaging v1.0. The Web Service Profile would be using TLS (like SMD).

# Project
This is a software library that provides an example implementation of a NEHTA Endpoint Location Service (ELS) Web Services client using .NET
 
The ELS is documented in Standards Australia Technical Report TR 5823-2010and is available from the following URL:
    http://infostore.saiglobal.com/store/portal.aspx?portal=Informatics.

# Setup
- To build and test the distributable package, Visual Studio must be installed.
- Load up the ELS.sln solution file.
- For documentation on the ELS library, refer to Help/Index.html.

# Solution
The solution consists of two projects:

ELS: The 'Nehta.VendorLibrary.SM.ELS' project contains the implementation of the 'Standards Australia - Endpoint Location Service' technical report.

Common: The 'Nehta.VendorLibrary.Common' project contains helper libraries common across all NEHTA vendor library components.

# Building and using the library
The solution can be built using 'F6'. 

# Client Instantiation
The ELS client may be instantiated in "Lookup Only" or "Lookup and Publish" modes. In "Lookup Only" mode, the client may query an ELS service but not publish to it. In "Lookup and Publish" mode, both queries and publishing of interactions my be done.

1. Requirements

   a) A public/private key pair and its associated public certificate. These are used to authenticate the client to an ELS Server during the Transport Layer Security (TLS) handshake. 

   b) The certificate of the Certificate Authority (CA) which signed the ELS server's TLS certificate. This certificate is used to authenticate the ELS server during the TLS handshake. 
 
   c) The Lookup and Publish TLS Web Service endpoint URLs for your ELS server(s).

2. Code Example

   // Obtain a client certificate by HPIO
   // The client certificate is used to authenticate the client to an ELS Server when establishing a TLS connection
   X509Certificate2 clientCert = X509CertificateUtil.GetCertificate("8003620000000001", X509FindType.FindBySubjectName);

   // Instantiating the client with the client certificate and client service endpoint url in "Lookup" mode
   ELSClient client = new ELSClient(new Uri("https://LookupServiceEndpointUrl"), clientCert);

   // Instantiating the client with the client certificate and client service endpoint urls in "Lookup and Publish" mode
   ELSClient client = new ELSClient(new Uri("https://LookupServiceEndpointUrl"), new Uri("https://PublishServiceEndpointUrl"), clientCert);
   
   Alternatively, the WCF client endpoints for the Lookup and Publish services can be configured in the "*.config" file, and the
   client can be instantiated with the respective endpoint configuration names:

   // Instantiating the client with the endpoint configuration names
   ELSClient client = new ELSClient("LookupEndpointConfigurationName", "PublishEndpointConfigurationName", clientCert);


# Generating service interfaces and classes from the WSDL and XSD files
1. With the installation of Visual Studio, the SvcUtil.exe tool should be installed.

2. Run the following command (or compile it into an executable *.cmd file):

   REM : This command has to be executed in the "WsdlAndXsd\endpointLocationService-1.3" directory
   REM : Set WSDLTOOL to the location of the local SvcUtil.exe installation
   SET WSDLTOOL="c:\Program Files\Microsoft SDKs\Windows\v6.0A\Bin\SvcUtil.exe"

   %WSDLTOOL% wsdl\*.wsdl xsd\*.xsd /out:ELSv2010.cs /noConfig /namespace:*,nehta.ELSv2010

# Licensing
See [LICENSE](LICENSE.txt) file.
