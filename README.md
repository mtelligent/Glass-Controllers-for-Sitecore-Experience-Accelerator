# Glass Controllers for Sitecore Experience Accelerator

This library allows you to easily build custom SXA Components that leverage Glass Types as Models. 

Normally to build a custom SXA Component, you need to define a custom Model, a repository class and wire things together with dependency injection.

Instead, this library allows you to inherit from GlassStandardController or GlassVariantController and have access to a generic SXA Repository that will give you your Glass types with the additonal SXA Model attributes to allow your component to work with SXA seamlessly.

It also registers all the Glass Context classes with the ServiceLocator for dependency injection purposes.

This library has been tested with Glass 5 on Sitecore 9.1 with SXA 1.8

