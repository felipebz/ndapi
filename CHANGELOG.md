# Changelog

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
