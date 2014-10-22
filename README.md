MultiPrefixRoute
================

It allows to apply multiple route prefixes using attributes in MVC5 like:
```c#
[RouteMPrefix("v1/values")]
[RouteMPrefix("v2/values")]
public class ValuesController : ApiController
{
  [Route("list")]
  [Route("get")]
  public IEnumerable<string> Get()
  {
    return new[] { "value1", "value2" };
  }
}
```

1. Add `MultiPrefixRouteProvider.cs` and `RouteMPrefixAttribute.cs` to your project
2. Use `MultiPrefixRouteProvider` when initializing attribute routing:
```c#
config.MapHttpAttributeRoutes (new MultiPrefixRouteProvider());
```

Detailed description is [here](http://blog.mshmelev.com/2014/10/multiple-routeprefix.html).
