# Protecting Data In Dot Net Examples

This solution contains 3 projects, each of those shows us how to protect our data by using .NET resources.


## About each project

I´m going to explain a little the projects that are in this solution:

#### 1st: DotNet_PluggableEncryption
This project shows an example of a pluggable encryption routine, the method EncryptData creates a sample byte buffer and then calls EncryptData_PluggableExample to perform the encryption.

#### 2nd: DotNet_ProtectedMemory
This project shows how to use a class provided for .NET Framework called "ProtectedMemory" which in addition to the "SecureString" class provides an easy way to protect sensitive data in memory.

#### 3rd: DotNet_SecureString
The project shows how to use the SecureString class, which automatically encrypts the contents of the class and ensures that only a single instance is maintained in addition, this class can be deleted explicitly from memory without relying on the .NET Framework garbage collector


#### 4th: DotNet_SQLiVulnerability
This project is only a script example of how the SQL injection works.

#### 5th: DotNet_XMLInjectionMitigation
Shows a small example about how to avoid the XML Injection, by using the property "InnerText" instead of "InnerXML" to concatenate new data into the XML, this way all the special characters that might be present in the string will be encoded and thus prevent XML injection. 

#### 6th: DotNet_XMLInjectionVulnerability
This project shows how the XML injection by the property "InnerXML" works. Using this property the attack will succeed since we are injecting bad data directly to the XML.  


## Prerequisites 

```
Install Visual Studio 2017
Install Git
```
Once you have installed the previous software, please clone my repo to your local machine. 


## Built With

* [Visual Studio 2017](https://www.visualstudio.com/thank-you-downloading-visual-studio/?sku=Community&rel=15)
* [Git](https://git-scm.com/download/win) 
* [GitHub](https://github.com)

## Authors

* **Nathali Aguayo** 
[GitHub](https://github.com/nathaliaguayos), [LinkedIn](https://www.linkedin.com/in/nathali-aguayo/)
