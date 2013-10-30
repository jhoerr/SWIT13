SWIT13
======

Hello!  You're probably here because you came to Patrick's and my talk on federating an ASP.Net application. Feel free to check out our [slides](https://iu.box.com/shared/static/m4v0wfcxtg7s232rb00m.pptx). Mind the animations.

You'll find in this repository the code as it appeared at the end of the demo. 
You can view the code as it was at the [beginning of the demo](https://github.com/jhoerr/SWIT13/tree/f731c3e144612dcea75c071f700c46a2a20ad519)
use the [demo script](https://iu.box.com/shared/static/ufw9quw74pdwkd9ngsus.txt) to implement things yourself.

A few notes:

This site is connected to a 'Local STS', which is a debug shim provided by Visual Studio that simulates a claims service provider.  If you'll recall, the trust
chain looks like this:

  App <---> Service Provider (SP) <---> Identity Provider (IdP) <---> CAS and AD
                                                                  
                                                       
The Local STS represents the SP and everything beyond it. For debugging purposes it allows us to configure the
specific claims that we want to get back. This is useful for dummying up claims for particular(s) role that are 
necessary for enabling certain privileges or getting to certain parts of your app.

Changing your application to point to a production service provider is essentially a matter of altering the URLs in the
web.config to point there. 

