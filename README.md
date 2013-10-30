SWIT13
======

Hello!  You're probably here because you came to Patrick's and my talk on federating an ASP.Net application.

You'll find in this repository the 'final' version of the demo. This site is connected to a 'Local STS', 
which is a debug shim provided by Visual Studio that simulates a claims service provider.  If you'll recall, the trust
chain looks like this:

  App <---> Service Provider (SP) <---> Identity Provider (IdP) <---> CAS
                                                                  \-> AD
                                                       
The Local STS represents the SP and everything beyond it. However with the Local STS we an configure the specific claims that
we want to get back. This is useful for dummying up claims for particular role that are necessary for getting to 
certain parts of your app.

