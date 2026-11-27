# Changelog

## [14.1.1](https://github.com/felipebz/ndapi/compare/14.1.0...14.1.1) (2026-11-27)


### Bug Fixes

* handle modules with no owner ([b485c92](https://github.com/felipebz/ndapi/commit/b485c92c6fd67a53a1cf1de6f77c87e7ca8c06be))

## [14.1.0](https://github.com/felipebz/ndapi/compare/14.0.0...14.1.0) (2026-11-27)


### Features

* **ndapi:** add Find, ObjectType and CreateMenuParameter, and deprecate the members they replace in Ndapi 15 ([298e83d](https://github.com/felipebz/ndapi/commit/298e83dfd0f723cecbc492340250134ea0e2b214))
* **ndapi:** deprecate creating and disposing NdapiContext instances ahead of Ndapi 15 ([970e3b4](https://github.com/felipebz/ndapi/commit/970e3b4a59a6a630954cbd0b6b1caa1a4ff8865d))
* **ndapi:** deprecate the instance Any() of the object library lists ahead of Ndapi 15 ([cb22148](https://github.com/felipebz/ndapi/commit/cb2214822db59985bd5f0ec8d65714fa7a13a52d))
* **ndapi:** make NdapiModule a closed hierarchy ([a2c19cc](https://github.com/felipebz/ndapi/commit/a2c19cc55db43db16722b98cf623a0dbb7aef8d2))


### Bug Fixes

* **ndapi:** cache the leaking PL/SQL text properties in the string accessors so every access path sees the same value ([079931c](https://github.com/felipebz/ndapi/commit/079931cb2ba883fd1671e1e254c86f1a66d2c7a0))
* **ndapi:** describe meta properties per declaring class instead of the first class loaded ([d02caad](https://github.com/felipebz/ndapi/commit/d02caad28d79fa537ad4a1f68e37cef5c3272a0d))
* **ndapi:** drop constructor trimming annotations that only forced callers to repeat them ([0b9e003](https://github.com/felipebz/ndapi/commit/0b9e00379ac80b09a29abaa4190145be26d8004b))
* **ndapi:** encode Forms 6i library and form load paths with the NLS charset like every other string ([90f060f](https://github.com/felipebz/ndapi/commit/90f060f8d47063d276902de83ef211f4e6c393a8))
* **ndapi:** free the persistent client info buffer when Forms rejects it ([b205ecb](https://github.com/felipebz/ndapi/commit/b205ecb60bbedab40525473ca89d23020c16cdf6))
* **ndapi:** keep a failed context creation from being reused by later calls ([f13dbe5](https://github.com/felipebz/ndapi/commit/f13dbe50323357b33e1aeb55e913caab2c5cac0b))
* **ndapi:** list the roles of a menu item instead of an empty sequence ([2e0f98f](https://github.com/felipebz/ndapi/commit/2e0f98f68a2d24c8e423381a1a9fb510f826ba05))
* **ndapi:** map Oracle charsets by name pattern and default to the OS code page instead of UTF-8 ([68a743a](https://github.com/felipebz/ndapi/commit/68a743a75f9b9a781452c643e7acae1c6d3a19e6))
* **ndapi:** pass file paths in the file system encoding instead ([6161490](https://github.com/felipebz/ndapi/commit/6161490f199dd2b789a79fdef68f21b2d98cf754))
* **ndapi:** redirect only the Forms library on Linux and leave other native imports to default probing ([b189c57](https://github.com/felipebz/ndapi/commit/b189c578fbcf92ecad57a8062446d4ba717492fb))
* **ndapi:** report Any() for object libraries and tabs holding a single object ([d8522ac](https://github.com/felipebz/ndapi/commit/d8522ac5f7d08493d816864a551fb6d4a24e17d0))
* **ndapi:** report native library load failures as NdapiException and keep their cause ([b8eaa74](https://github.com/felipebz/ndapi/commit/b8eaa74fd0a63f50c805a6dd9da7495a13aba2c5))
* **ndapi:** require an STA thread on every Windows Builder, not only Forms 6i ([03e0df6](https://github.com/felipebz/ndapi/commit/03e0df69d9e0c95a0f9b96c57caf23dcfd6496fc))
* **ndapi:** resolve the owning library of tabs read from an object library ([8c1df98](https://github.com/felipebz/ndapi/commit/8c1df98e982ac368a84e1362d46585f1e1393d84))
* **ndapi:** return a snapshot of the open modules so they can be closed while iterating ([c8d6f8f](https://github.com/felipebz/ndapi/commit/c8d6f8fe1307f3df7534ffea7ff9f0f57705c975))
* **ndapi:** stop RemoveAll from destroying the last object twice and honor the enumerator contract ([aa1b2c3](https://github.com/felipebz/ndapi/commit/aa1b2c36f706a777aa485bfc4aae3dc964d4978b))
* **ndapi:** throw ArgumentNullException for null object arguments instead of NullReferenceException ([33a49b0](https://github.com/felipebz/ndapi/commit/33a49b0272ce184d6e082500af39164c32b61023))
* **ndapi:** throw ObjectDisposedException on wrappers whose native object was destroyed ([7501059](https://github.com/felipebz/ndapi/commit/7501059608e7ee25e15bfd993e0c4bb65e13f6a1))


### Performance Improvements

* **ndapi:** cache the supported properties, read native counts once per enumeration and retry failed lazy loads ([98d3c73](https://github.com/felipebz/ndapi/commit/98d3c7303607eb6e4c5addbf7dd6bd9bcc79da6a))
* **ndapi:** convert enum properties without boxing and through a cached reverse lookup ([9836fe3](https://github.com/felipebz/ndapi/commit/9836fe3bf9e48e881539c31e28f71533c4cdce70))
* **ndapi:** look up object type mappings by dictionary instead of scanning the list ([8022a52](https://github.com/felipebz/ndapi/commit/8022a526a086dcfcc920e8ecebdc72ebc94b20b0))
* **ndapi:** marshal NLS strings through spans ([3775acb](https://github.com/felipebz/ndapi/commit/3775acb8cdfc0b24c2162c15de327ca208a65543))
* **ndapi:** stop finalizing object handles, which own nothing, and share one handle for null arguments ([265ddb5](https://github.com/felipebz/ndapi/commit/265ddb55153de69d79cd6b3312bd961e5e5ce554))

## [14.0.0](https://github.com/felipebz/ndapi/compare/Ndapi-13.1.0...Ndapi-14.0.0) (2026-11-20)


### ⚠ BREAKING CHANGES

* **ndapi:** enable nullable reference types and annotate the public API
* **ndapi:** fix public API naming and validate API compatibility against the last release
* **ndapi:** add typed members for properties missing in every Builder version
* **ndapi:** align properties and data source objects with every Builder version

### Features

* Add constants for Oracle Forms 14.1.2.0 ([670a4d2](https://github.com/felipebz/ndapi/commit/670a4d23891789c9c7918ccb9f903e2122db8604))
* Add Linux support for Forms 12c+ ([5969feb](https://github.com/felipebz/ndapi/commit/5969febe81e06ea00caeebb25082df7e6e6da161))
* Add new Alert properties from Forms 14.1.2.0 ([baf7dea](https://github.com/felipebz/ndapi/commit/baf7deafc9596e865147d6ea83019117d9a9db1d))
* Add new Block properties from Forms 14.1.2.0 ([03b9486](https://github.com/felipebz/ndapi/commit/03b9486dd727f6a684f26b233a00b8f4898e82f3))
* Add new Canvas properties from Forms 14.1.2.0 ([867d8d6](https://github.com/felipebz/ndapi/commit/867d8d64a7e1c6140b31a8c5e1b43e9e67c9ea27))
* Add new Editor properties from Forms 14.1.2.0 ([2edde88](https://github.com/felipebz/ndapi/commit/2edde8868df6cfd0891f3eca5996539edb456e93))
* Add new Event properties from Forms 14.1.2.0 ([47fc20b](https://github.com/felipebz/ndapi/commit/47fc20bbfd017b0217d0da8aff0a9f8b44a83787))
* Add new FormModule properties from Forms 14.1.2.0 ([1da4c3b](https://github.com/felipebz/ndapi/commit/1da4c3bff36835e1efbf2ae54f897b5ecb5b418c))
* Add source generator to implement the properties ([#47](https://github.com/felipebz/ndapi/issues/47)) ([f28a6b4](https://github.com/felipebz/ndapi/commit/f28a6b43ca5962e76d4460713dbfe81ed641a8f3))
* Improve source generator to cover more situations ([4ce16c0](https://github.com/felipebz/ndapi/commit/4ce16c0b23217e1b375c6d8819a0b63270dc8197))
* **metadata:** expose every property supported by the running Builder ([ab4d2f0](https://github.com/felipebz/ndapi/commit/ab4d2f03dd807cbc470d111fdd3f7076ee3e8182))
* **ndapi:** add BI Publisher report properties ([6508a67](https://github.com/felipebz/ndapi/commit/6508a678e372827de153cd2951027947c12fa3a6))
* **ndapi:** add Forms 12c/14c enums and properties ([31a4278](https://github.com/felipebz/ndapi/commit/31a42781d6deacf02ed5b745ec8cbf8ee170d0fe))
* **ndapi:** add string ids and generic subclassing properties ([ee6a02f](https://github.com/felipebz/ndapi/commit/ee6a02f0f3fa7eb99ce5a8e4a04c48593d53d318))
* **ndapi:** add typed members for properties missing in every Builder version ([7fe6fd1](https://github.com/felipebz/ndapi/commit/7fe6fd100d788e87f98f0ea6ca1e4b05d2499a1e))
* **ndapi:** bind blob properties, image export, library compile and load details ([1bcb62d](https://github.com/felipebz/ndapi/commit/1bcb62de4403037649a6e1cd9188f007cc86ae7a))
* **ndapi:** enable nullable reference types and annotate the public API ([f0c073d](https://github.com/felipebz/ndapi/commit/f0c073d9d71581388237f9b926ef4cf4328245b0))
* **ndapi:** fix public API naming and validate API compatibility against the last release ([1446214](https://github.com/felipebz/ndapi/commit/14462148fea5b5a0e414ed7b9f07eecd9346acfa))
* **ndapi:** target net11.0 ([b539009](https://github.com/felipebz/ndapi/commit/b5390093738883e100908bbb03c73d8030958c76))
* Update ConstantConverter to handle Forms 14 properties ([a83c970](https://github.com/felipebz/ndapi/commit/a83c9704cda33419abbfb51cf68ac0cb3ba8ae40))
* Use the source generator to implement all properties (closes [#47](https://github.com/felipebz/ndapi/issues/47)) ([0d84151](https://github.com/felipebz/ndapi/commit/0d84151237517fd755dc7014079aced466b67aa3))


### Bug Fixes

* Fix build ([e6e2fc4](https://github.com/felipebz/ndapi/commit/e6e2fc40a1bf6e87e269b76a310d49d6955c00ee))
* Fix csproj and format files ([c8b878a](https://github.com/felipebz/ndapi/commit/c8b878a75b1d8b94e301dc9bb841edd19711427e))
* **generator:** implement lazy caching for toxic native properties to prevent memory leaks ([321b054](https://github.com/felipebz/ndapi/commit/321b054381a05d08de7d675c2e7bc39533715da2))
* **metadata:** clear error for object types without an Ndapi class ([cf7becd](https://github.com/felipebz/ndapi/commit/cf7becd15dac49a394c289fa85ebff946ac3aecb))
* **metadata:** look up AllowedValues names with the enum member value ([2950db0](https://github.com/felipebz/ndapi/commit/2950db03e508d2d18397c06d197057f90999c372))
* **ndapi:** accept null in Move, as documented ([997ba81](https://github.com/felipebz/ndapi/commit/997ba810f9eede6ce3b16ddaf1ce51ac85600ed0))
* **ndapi:** add `NdapiObjectRegistry` to track and manage object lifetimes ([4fabf5d](https://github.com/felipebz/ndapi/commit/4fabf5dd34276f40681ea147aed87c8d03959ecc))
* **ndapi:** add NLS string marshaller to ensure proper memory management for string properties ([341cb58](https://github.com/felipebz/ndapi/commit/341cb58c702ed4819f93e7e34f23e5172bf6ffaa))
* **ndapi:** align properties and data source objects with every Builder version ([3fee8fa](https://github.com/felipebz/ndapi/commit/3fee8fa44a205ae93d3237552ae5134ca6bd5b6c))
* **ndapi:** correct string property retrieval to prevent memory leaks by freeing unmanaged memory ([3f627f6](https://github.com/felipebz/ndapi/commit/3f627f60d7bd3a205e0fa9b2a8a9ee0139eec80b))
* **ndapi:** drop cached wrappers when an object is destroyed ([f2e17c3](https://github.com/felipebz/ndapi/commit/f2e17c32377f72817ed8629e7213054419db93f8))
* **ndapi:** register modules in NdapiContext only when directly created, not via properties like block.Owner ([6ffde16](https://github.com/felipebz/ndapi/commit/6ffde16683ced9dc9eb25579802f8cd29958f7fa))
* **ndapi:** reject characters the module charset can't represent ([229e829](https://github.com/felipebz/ndapi/commit/229e829319a2779b275b58f493a12289061047f9))
* **ndapi:** report constants missing in the running Builder as NdapiException ([c524fc1](https://github.com/felipebz/ndapi/commit/c524fc1d7f5b9223c95fd0bfeb92117bee0088a4))
* **ndapi:** resolve the Forms library lazily and reject non-STA threads on Forms 6i ([049051a](https://github.com/felipebz/ndapi/commit/049051a1f6c7ed837dc7df7547ac198dd8502b35))
* **ndapi:** return the opening module instance from object module references ([cbf3926](https://github.com/felipebz/ndapi/commit/cbf392641c963f001311f9adc022dda47aea148a))
* **ndapi:** unload a module when the instance that opened or created it is disposed ([2307857](https://github.com/felipebz/ndapi/commit/230785772754853a1558b1322e24740540c6d10a))
* **ndapi:** use Forms 14 constants for Builder 14 ([d06106e](https://github.com/felipebz/ndapi/commit/d06106eb1c3ef35c7d68f0ae2e31f0369b3bbce2))
* Remove unnecessary output ([4bcb39b](https://github.com/felipebz/ndapi/commit/4bcb39bb788b6b341328886aaeff2826c2c8d18e))
* **source-generator:** target AnyCPU ([1d1da9c](https://github.com/felipebz/ndapi/commit/1d1da9c98db264bcbf7c682cc88b73dcf133a4bd))
