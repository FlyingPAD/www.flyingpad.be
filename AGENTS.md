# AGENTS.md

Flying PAD is a product repository inside **The Ninth Pad**.

## Upstream authority

1. **Current repository implementation** — what the site actually does now.
2. **Flying PAD docs** — `docs/`; product identity, pedagogy, design and local engineering decisions.
3. **The Ninth Pad** — `FlyingPAD/the-ninth-pad`; shared canon/philosophy, Pads, Source, White and Guardian/Hunter shared meaning.
4. **Production OS** — `FlyingPAD/production-os`; reusable collaboration, stack, production pipelines and QA.

One durable fact must have one owner.

## Start-of-task read order

1. Fetch current `master` HEAD.
2. Read this file.
3. Read relevant Production OS docs when method/engineering/QA matters.
4. Read relevant The Ninth Pad canon when shared philosophy or mythology matters.
5. Read [docs/README.md](docs/README.md) and the relevant Flying PAD owner.
6. Inspect the current implementation owner before changing code.

## Product boundary

Flying PAD is the public learning/creation/transmission side of The Ninth Pad.

Do not copy the whole shared mythology here. This repo owns how Flying PAD **expresses and teaches** it.

## Repository roles

- `README.md` — project/development presentation.
- `AGENTS.md` — operational routing.
- `docs/` — durable Flying PAD-specific truth.
- `front/` + `back/` + config — implementation.

## Engineering

Inherit the preferred Production OS direction:
- Angular / TypeScript / SCSS frontend;
- C# / .NET / ASP.NET Core backend;
- domain-oriented/Clean Architecture when useful;
- relational persistence via EF Core/SQL Server in the current product;
- simplest robust mechanism over fashionable fragmentation.

Current implementation must still be inspected before making version/framework claims.

## Documentation

When meaning changes:
- reusable method → Production OS;
- shared Ninth Pad philosophy/canon → The Ninth Pad;
- Flying PAD pedagogy/product/design → this repo;
- implementation detail → code/config.

Do not create duplicate bibles.
