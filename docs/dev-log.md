# Development log

One entry per sitting, newest first. The "Next sitting" block is rewritten at the
end of every sitting so the next one starts without guesswork.

## Next sitting
Week 2, in this order (board: https://github.com/users/JeremyIB/projects/1):
1. Review and squash-merge Dependabot PR #7 if `build-test` is green (5 min).
2. #2 Postgres with pgvector in Docker. Start the image pull first so it
   downloads while you work on the wireframes.
3. #1 Wireframes for the nine screens. They don't exist yet, so this sitting
   creates them; time-box to 75 minutes.
4. #3 B1 EF Core entities, then #4 first migration.
5. #5 ADR-0002 (Should).

Cut line: week 2 is now heavier than the plan assumed, because it creates the
wireframes instead of reviewing them. If the sitting reaches 3h, ADR-0002 slips
first and the migration second; push them to week 3 rather than running long.
Write each block's finishing time in this log as you go.

## 2026-10-02 — Week 1, sitting 2: governance, tracking, close-out (7.1–8.2)
- Done:
  - Plan documents moved to `docs/planning/`; README layout updated.
  - Dependabot for NuGet and GitHub Actions (7.2). Its first runs succeeded for
    both ecosystems and opened PR #7 (Microsoft.NET.Test.Sdk 18.10.0 → 18.10.1),
    which shows it handles central package management.
  - Merge settings: squash only, head branches deleted automatically (7.1).
  - Ruleset `main` on the default branch (7.1): pull request required
    (0 approvals, squash only), status check `build-test` required and pinned to
    the GitHub Actions app, force pushes and deletion blocked, no bypass actors.
    A direct push to `main` was rejected with GH013.
  - Labels (must/should/could, feature/chore/docs/test/ci, phase-0 to phase-6),
    four milestones M1–M4, and week-2 issues #1–#5 plus #6 (Ubuntu 26 runner
    check) in M1, on a public project board (7.3).
  - Checklist walk (8.1): all 20 items met. Fresh clone: `CI=true dotnet build
    -c Release` gave 0 warnings, `dotnet test` gave 1 passed, and `dotnet run`
    served `/` (200) and `/health` (200 `Healthy`). The latest `main` run
    finished in 18s with a `test-results` artifact. The badge reads passing, the
    repo opens logged out, every commit email is the no-reply address, and
    `docker run hello-world` succeeds.
  - This close-out is the first change to reach `main` through a pull request.
- Decisions taken without an ADR:
  - Dependabot groups NuGet minor and patch updates only. A major update gets
    its own PR so a breaking change can be held back alone. GitHub Actions
    updates are grouped wholesale.
  - Dependabot PRs use our labels (`chore`, `ci`) and Conventional Commit
    prefixes. Grouped PRs come out as `chore: …` without the `(deps)` scope;
    that is acceptable.
  - Squash commits take the PR title, so PR titles must be Conventional Commits.
    Commit bodies are kept, which preserves co-author trailers.
  - The ruleset has no bypass actors: the admin goes through the gate too.
    GitHub now adds `require_extra_approval_for_unattributed_changes` to new
    rulesets; it did not block a 0-approval merge.
  - Dependabot alerts and security updates turned on (not in the spec; free).
  - Wiki turned off: documentation lives in the repo.
  - Default labels `documentation` and `enhancement` deleted (duplicates of
    `docs` and `feature`). Phase labels mark when the work happens, so B1
    entities are `phase-0` even though the B1 story is phase 2.
  - Milestone due dates display as dates; GitHub stores them at 00:00 UTC.
- Blocked by / surprised by: nothing blocked. Docker Desktop was installed but not
  running; it started cleanly.
- Estimate vs actual: planned 4h; actual about 4h in total across both sittings.
  Per-block times were not recorded.
- End-of-week review:
  1. Longest block against its estimate: unknown, because clock times weren't
     logged. The visible slip is that blocks G–H (governance and close-out)
     moved to a second sitting a week later.
  2. Differently in week 2: write each block's finishing time in this log
     during the sitting, and start the Docker image pull before anything else.
  3. Plan now wrong: the wireframes don't exist, so week 2 creates them rather
     than reviewing them (#1). That makes week 2 heavier; the cut line in "Next
     sitting" handles it. Week 1 also closed during week 2's calendar week
     (2 Oct).

## 2026-09-25 — Week 1, sitting 1 (planned 4h for the week; actual in sitting 2's entry)
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
  All done in sitting 2.
- Decisions taken without an ADR:
  - Kept the `.slnx` solution format that `dotnet new sln` produces on .NET 10.
  - The test project uses `xunit.v3.mtp-off`, the xunit.v3 template's VSTest
    variant, so `dotnet test --logger trx` works as the CI spec expects.
  - CI uses the current action majors (checkout v7, setup-dotnet v6,
    upload-artifact v7) rather than the older ones in the week-1 spec.
- Blocked by / surprised by:
  - Nothing blocked. CI annotates that `ubuntu-latest` moves to Ubuntu 26 from
    19 Oct 2026; watch the first run after that date.
- Estimate vs actual: recorded for the whole week in sitting 2's entry.
