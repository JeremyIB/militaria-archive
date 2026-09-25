# Militaria Archive

[![CI](https://github.com/JeremyIB/militaria-archive/actions/workflows/ci.yml/badge.svg?branch=main)](https://github.com/JeremyIB/militaria-archive/actions/workflows/ci.yml)

A private-by-default archive for military memorabilia, where embedding-based search connects objects, images, and the stories behind them across collections.

**Status:** Week 1 of 26 — foundation. The solution builds, one test passes, and CI checks every push. Everything below marked *planned* is not built yet.

## What it will do

Collectors sign in behind two-factor authentication and catalogue each piece with structured attributes, photographs and its written history. Items are private by default; owners choose what to share. Semantic search over text and image embeddings then surfaces connected material, such as a cap badge from the same regiment or a story about the campaign a medal was awarded in.

## Planned screens

1. Sign-up and sign-in
2. Two-factor enrollment
3. Two-factor challenge
4. My collection
5. Add / edit item
6. Item detail
7. Story editor and story page
8. Public collector profile
9. Moderator queue

## Tech stack

- **In use:** C# on .NET 10, Blazor Web App (Server interactivity), xUnit, GitHub Actions
- **Planned:** PostgreSQL with pgvector, EF Core, ASP.NET Core Identity with TOTP, Azure Blob Storage, Azure OpenAI and Azure AI Vision embeddings, Azure Functions, Azure App Service, Key Vault

## Roadmap

| Milestone | Target |
| --- | --- |
| M1 Security story complete | 25 Oct 2026 |
| M2 Live URL | 6 Dec 2026 |
| M3 AI discovery evaluated | 7 Feb 2027 |
| M4 Portfolio-grade | 18 Apr 2027 |

## Run locally

Requires the [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0) (10.0.202 or later).

```bash
git clone https://github.com/JeremyIB/militaria-archive.git
cd militaria-archive
dotnet build
dotnet test
dotnet run --project src/Militaria.Web
```

Then open <http://localhost:5112>; the health check is at <http://localhost:5112/health>.

## Repository layout

```text
src/Militaria.Domain/          domain types, no dependencies
src/Militaria.Web/             Blazor UI and API endpoints
tests/Militaria.Domain.Tests/  unit tests
docs/adr/                      architecture decision records
docs/dev-log.md                development log
.github/workflows/ci.yml       build and test on every push
```

## Design decisions

- [ADR-0001: Target .NET 10 LTS rather than .NET 8](docs/adr/0001-target-dotnet-10-lts.md)

## License

[MIT](LICENSE)
