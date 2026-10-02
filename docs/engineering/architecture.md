# Flying PAD Engineering

## Current repository shape

```text
www.flyingpad.be
├── front/   Angular frontend
├── back/    .NET solution
└── docker-compose.yml
```

The current backend is organized as a Clean Architecture-style solution with API, Application, Domain, Infrastructure and Persistence projects plus tests.

The frontend is Angular with custom SCSS-oriented design.

## Direction

Inherit `FlyingPAD/production-os` for global engineering preferences.

Local principles:
- preserve clear front/back boundaries;
- keep business/domain truth out of presentation;
- use framework-native/current Angular and .NET idioms;
- prefer cohesive end-to-end design over introducing unrelated stacks;
- keep pedagogy/content models explicit enough that new learning formats can grow without duplicating mechanics.

## Validation

Use the real project build/test commands from the current repository/config. Do not claim a build or test pass unless it ran.
