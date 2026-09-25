# Development log

One entry per sitting, newest first. The "Next sitting" block is rewritten at the
end of every sitting so the next one starts without guesswork.

## Next sitting
Week 2: open docs/wireframes, cut non-Must elements, then B1 (EF Core entities
for the data model). Issue number added when the week-2 issues are created (task 7.3).

## 2026-09-25 — Week 1 (planned 4h, actual: filled in at close-out, task 8.2)
- Done:
  - Repository, hygiene files, pinned SDK (2.1–2.4).
  - Three-project solution with central build settings and package versions;
    `/health` endpoint; 0-warning build (3.1–3.4).
  - `ItemVisibility` and its first unit test (4.1–4.2).
  - CI workflow green on `main` in 35 seconds (5.1–5.2).
  - Gate proven on the deleted `ci/prove-gate` branch: a failing test went red
    at the Test step, and a CS0168 warning went red at the Build step (5.3).
  - ADR template and ADR-0001, this log, pull request template, README v1 (6.1–6.3).
- Still open this week: branch ruleset and merge settings (7.1), Dependabot (7.2),
  labels, milestones and week-2 issues (7.3), checklist walk and close-out (8.1–8.2).
- Decisions taken without an ADR:
  - Kept the `.slnx` solution format that `dotnet new sln` produces on .NET 10.
  - The test project uses `xunit.v3.mtp-off`, the xunit.v3 template's VSTest
    variant, so `dotnet test --logger trx` works as the CI spec expects.
  - CI uses the current action majors (checkout v7, setup-dotnet v6,
    upload-artifact v7) rather than the older ones in the week-1 spec.
- Blocked by / surprised by:
  - Nothing blocked. CI annotates that `ubuntu-latest` moves to Ubuntu 26 from
    19 Oct 2026; watch the first run after that date.
- Estimate vs actual: filled in at close-out (task 8.2).
