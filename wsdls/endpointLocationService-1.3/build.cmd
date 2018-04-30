cls
SET WSDLTOOL="c:\Program Files (x86)\Microsoft SDKs\Windows\v7.0A\Bin\SvcUtil.exe"

%WSDLTOOL% wsdl\*.wsdl xsd\*.xsd /out:ELSv2010.cs /noConfig /namespace:*,Nehta.ELSv2010

PAUSE
