# 0001. Target .NET 10 LTS rather than .NET 8

- Status: Accepted
- Date: 2026-09-24

## Context
The project plan names ASP.NET Core 8. .NET 8 (LTS) and .NET 9 (STS) both reach
end of support on 10 November 2026, three weeks before the week-11 live URL
(week of 30 November 2026). Launching on a runtime that is already out of support
would mean no security patches from day one, and it is the first thing a reviewer
would flag. .NET 10 is the current LTS release, supported until 14 November 2028,
which covers the whole build and the interview season after it. The solution is
still empty, so changing the target now costs one property value.

## Decision
Target `net10.0` for every project, set once in `Directory.Build.props`, and pin
the SDK in `global.json` (10.0.202, `rollForward: latestFeature`) so local builds
and CI use the same SDK. The rest of the plan's stack is unchanged.

## Alternatives considered
- **.NET 8 LTS, as the plan says.** Out of support before launch; it would force a
  migration mid-project, in the busiest weeks.
- **.NET 9 STS.** Same end-of-support date as .NET 8, so it has the same problem
  and no longer support window to make up for it.

## Consequences
- Easier: no forced runtime migration before November 2028; current C# and
  ASP.NET Core features are available.
- Harder: an editor with .NET 10 support is required (Visual Studio 2026, current
  Rider, or VS Code with C# Dev Kit); older Visual Studio 2022 builds cannot
  target it.
- Revisit in week 10: confirm Azure App Service (Linux) offers the .NET 10
  runtime when it is provisioned. Revisit again before November 2028, when the
  next LTS release is the upgrade path.
