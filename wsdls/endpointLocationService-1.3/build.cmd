cls
SET WSDLTOOL="c:\Program Files\Microsoft SDKs\Windows\v6.0A\Bin\SvcUtil.exe"

%WSDLTOOL% wsdl\*.wsdl xsd\*.xsd /out:ELSv2010.cs /noConfig /namespace:*,Nehta.ELSv2010

PAUSE
