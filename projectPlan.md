**Militaria Archive — Project Plan**

*A cataloguing and storytelling platform for war and military memorabilia collectors. Built for Jeremy Baron, four hours per week, starting the week of 21 September 2026\. Prepared 15 September 2026\.*

**What he is building**

A collector logs in behind two-factor authentication, catalogues each piece he owns with proper attributes and photographs, writes the history of the object alongside it, and opens it to other enthusiasts who can add their own pieces, contribute stories, and comment on each other’s. Semantic search over descriptions and images then surfaces connected material — another collector’s cap badge from the same regiment, a story about the campaign a medal was awarded in, a photograph showing the same maker’s mark.

**The one-line version, for a README and for interviews:** “A private-by-default archive for military memorabilia, where embedding-based search connects objects, images, and the stories behind them across collections.”

**Why this is the right project for him**

Three reasons beyond the fact that he cares about the subject, which matters more than it sounds — a four-hour-a-week commitment across two semesters survives only if he wants to open the laptop.

* **It extends work he has already done rather than starting over.** At AMAXST he built a similarity-search tool that ranked comparable historical quotes by weighted feature scoring. This project is that same instinct rebuilt properly: embeddings and vector search instead of hand-tuned weights. “I built similarity search with hand-weighted features at work, then rebuilt it with embeddings and measured the difference” is a genuine engineering-growth story, and almost no undergraduate has one.

* **It closes the exact gaps his resume review named.** Testing, CI/CD, a public repository, a live URL, and a project dated this year instead of 2024 — all five come out of the first eleven weeks.

* **It stays in C\# and Azure.** Every hour deepens the stack he is already selling instead of scattering across a new one.

**Scope discipline — the four-hour reality**

Four hours a week from late September to mid-April is roughly 100 hours. That is enough for a genuinely good narrow product and nowhere near enough for the platform it is tempting to imagine. So the plan is ordered by what has to exist for the thing to be real, and the single most important line in this document is the one about week 11\.

**New-grad applications go out between now and December.** That means weeks 1 to 11 — accounts, 2FA, items, images, stories, deployed to a public URL — are the resume-critical stretch, and everything after week 11 is upside he adds while interviewing. If the schedule slips, it slips on the community features, never on getting something deployed.

**Explicitly out of scope, and why**

* **No marketplace, payments, or auctions.** Payments would consume the entire hour budget on compliance work nobody is going to interview him about.

* **No valuation or appraisal features.** Telling collectors what their pieces are worth invites liability and disputes he has no reason to take on. Being able to explain why he deliberately left this out is itself a good interview answer.

* **No native mobile apps and no real-time chat.** A responsive web layout covers the need at a fraction of the cost.

One subject-matter caution worth stating plainly: a public archive of military memorabilia will attract submissions of insignia and regalia from regimes whose symbols are regulated in some countries and offensive in most. He should write a short content policy before the site is public, and the moderation queue and automated screening in Phase 5 are not optional garnish — they are what make the project defensible when he demos it.

**Requirements — user stories**

Twenty-six stories, prioritized MoSCoW. Must means the product is not real without it; Could means it goes in only if the hours appear.

| ID | User story | Priority | Phase |
| :---- | :---- | :---- | :---- |
| A1 | As a collector, I want to register with an email and password so I can own a collection. | Must | 0 — Foundation |
| A2 | As a collector, I want to enroll an authenticator app by scanning a QR code so my account has a second factor. | Must | 1 — Security |
| A3 | As a collector, I want to be challenged for a 6-digit code at login once 2FA is on, so a stolen password is not enough. | Must | 1 — Security |
| A4 | As a collector, I want single-use recovery codes so losing my phone does not lock me out permanently. | Must | 1 — Security |
| A5 | As a collector, I want email confirmation and password reset so account recovery is self-service. | Should | 5 — Community |
| B1 | As a collector, I want to add an item with type, conflict, era, nation, branch, unit, maker, marks, and condition so it is properly catalogued. | Must | 2 — Collection |
| B2 | As a collector, I want to upload several photographs per item and choose a primary image so the listing shows the piece properly. | Must | 2 — Collection |
| B3 | As a visitor, I want an item detail page showing images, attributes, story, and related items so I can understand the piece. | Must | 2 — Collection |
| B4 | As a collector, I want to browse, filter, and search my own collection so I can find a piece among hundreds. | Must | 2 — Collection |
| B5 | As a collector, I want per-item visibility (private, unlisted, public) so I control what is exposed. | Should | 5 — Community |
| B6 | As a collector, I want a controlled taxonomy for conflict, era, nation, branch, and item type so filtering actually works. | Should | 2 — Collection |
| B7 | As a collector, I want a provenance timeline per item so the chain of custody is recorded. | Could | 6 — Later |
| C1 | As a collector, I want to write a long-form story attached to an item so the history travels with the object. | Must | 2 — Collection |
| C2 | As a writer, I want to publish a standalone story not tied to one item so I can write about a unit or a campaign. | Should | 5 — Community |
| D1 | As an enthusiast, I want to comment on an item or story so I can add identification help or context. | Must | 5 — Community |
| D2 | As an enthusiast, I want to reply to a comment so discussions thread instead of flattening. | Should | 5 — Community |
| D3 | As an enthusiast, I want to follow a collector and see an activity feed so I keep up with new additions. | Could | 6 — Later |
| E1 | As a visitor, I want to see items and stories related to the one I am viewing so I can discover connected pieces. | Must | 4 — AI |
| E2 | As a visitor, I want to see visually similar items so I can compare insignia, medals, and markings across collections. | Should | 4 — AI |
| E3 | As a collector, I want suggested tags from an uploaded photograph so cataloguing a new piece is faster. | Could | 6 — Later |
| E4 | As a collector, I want maker marks and documents read by OCR into searchable text so stamped details are findable. | Could | 6 — Later |
| F1 | As any user, I want to report a comment, image, or item so harmful content can be removed. | Should | 5 — Community |
| F2 | As a moderator, I want a queue of reported and auto-flagged content so I can act on it consistently. | Should | 5 — Community |
| F3 | As the operator, I want new text and images screened automatically before they go public so the site is defensible. | Should | 5 — Community |
| G1 | As the developer, I want every push built and tested automatically and main deployed to Azure so shipping is not a manual ritual. | Must | 0 / 3 |
| G2 | As a collector, I want to export my collection to CSV or PDF so I am not locked in and have an insurance record. | Could | 6 — Later |

**Acceptance criteria for the three that matter most**

**A2 / A3 — two-factor authentication.** Enrolling produces a QR code an authenticator app accepts; a correct 6-digit code enables 2FA and an incorrect one does not; once enabled, a password-only login is refused and a code is demanded; ten recovery codes are issued, each works exactly once, and using one does not disable 2FA; five consecutive failures lock the account for a defined window. Every one of these is a test.

**B2 — image upload.** Several images attach to one item; exactly one is primary at any time; files over a size limit and non-image MIME types are rejected with a useful message; the original is preserved and a thumbnail is generated; deleting an item removes its blobs.

**E1 — related items.** Every saved item gets a text embedding within a minute without blocking the save; the item page shows up to ten related items ordered by cosine distance; private items belonging to other users never appear; an item never appears as related to itself; and if embedding generation fails the page still renders with the section simply absent.

**Data model**

Eight tables. Start here and resist adding a ninth before it is needed.

AppUser        Id, Email, DisplayName, PasswordHash, TwoFactorEnabled,  
               AuthenticatorKey, Role, CreatedAt          (ASP.NET Core Identity)  
Item           Id, OwnerId \-\> AppUser, Title, ItemType, Conflict, Era, Nation,  
               Branch, Unit, Maker, Marks, Condition, AcquiredOn,  
               ProvenanceNotes, Visibility, CreatedAt, UpdatedAt  
ItemImage      Id, ItemId \-\> Item, BlobUri, ThumbUri, Caption, IsPrimary,  
               Width, Height, SortOrder  
Story          Id, ItemId \-\> Item (nullable), AuthorId \-\> AppUser, Title, Body,  
               Visibility, PublishedAt  
Comment        Id, ParentCommentId \-\> Comment (nullable), ItemId (nullable),  
               StoryId (nullable), AuthorId, Body, CreatedAt, IsHidden  
Tag / ItemTag  controlled taxonomy: conflict, era, nation, branch, item type  
ItemEmbedding  ItemId \-\> Item, TextVector vector(1536), ImageVector vector(1024),  
               ModelName, ModelVersion, GeneratedAt  
Report         Id, ReporterId, TargetType, TargetId, Reason, Status, ResolvedById

**Two notes.** Storing ModelName and ModelVersion on every embedding row is what lets him swap embedding models later as a deliberate re-index rather than a silent corruption of his search results — a small decision that reads as experience. And Comment pointing at either an Item or a Story with a nullable self-reference for threading is the simplest shape that supports the feature; a polymorphic join table would be cleaner in theory and slower to build.

**Tech stack**

Chosen to compound with what he already sells, not to collect new logos. The third column is what he should be able to say when an interviewer asks why.

| Layer | Choice | Why this one — and the tradeoff to be ready to defend |
| :---- | :---- | :---- |
| API | ASP.NET Core 8 Web API (C\#) | His deepest skill. Every hour here compounds with the AMAXST experience already on his resume rather than diluting it. |
| Frontend | Blazor Web App | He already knows Blazor/Razor, so the UI is not the thing that stalls him. Tradeoff: React is more in demand — the honest defense is that shipping in a stack he knows beat learning two things at once at four hours a week. |
| Database | Azure Database for PostgreSQL Flexible Server \+ pgvector | The important decision. He knows MySQL, but MySQL has no mature pgvector equivalent, so vectors would need a second datastore. Postgres keeps relational rows and embeddings in one place and is the more common backend database in job postings. Microsoft documents pgvector on Flexible Server directly, including an index-tuning guide. |
| ORM | Entity Framework Core \+ migrations | Migrations in source control are what make the deploy story credible. |
| Auth \+ 2FA | ASP.NET Core Identity with TOTP authenticator apps | Built in: QR enrollment, 6-digit verification, recovery codes, lockout. Deliberately NOT Entra External ID — he already has Entra ID/MSAL on his resume, so hand-wiring Identity adds a new skill instead of repeating one. Document Entra External ID as the considered alternative. |
| Image storage | Azure Blob Storage | Images never belong in the database. Add a CDN only when load justifies it. |
| Text embeddings | Azure OpenAI text-embedding-3-small (1536 dimensions) | Cheap, fast, good enough. Store the model name and version on every row so a future model change is a re-index, not a mystery. |
| Image embeddings | Azure AI Vision multimodal embeddings | Managed image vectorization, and the text and image vectors share a space so a text query can retrieve images. Alternative worth naming: CLIP locally via ONNX Runtime — free, and he has already run a Dockerized model locally. |
| Background work | Azure Functions, queue-triggered | He already knows Azure Functions from AMAXST. Embedding generation must not run inside the upload request — see the architecture note below. |
| Hosting | Azure App Service (Linux) | Cheapest credible path from a GitHub Actions deploy to a public URL. |
| Secrets | Azure Key Vault \+ Managed Identity | No connection strings in source. Interviewers notice this; students rarely do it. |
| CI/CD | GitHub Actions — build, test, deploy | Fixes a gap his current resume has: he does professional .NET work and shows no pipeline. |
| Testing | xUnit, FluentAssertions, Testcontainers, Playwright | Unit, real-Postgres integration, and browser end-to-end. See the testing section — this is the part that most separates him from other applicants. |
| Observability | Serilog \+ Application Insights | So "it broke in production" has an answer. |
| Moderation | Azure AI Content Safety | Not polish. Anything public that accepts user images and text needs it. |
| Cost control | Azure for Students credit \+ a budget alert | The student offer carries a \$100 credit. Set a budget alert at \$25 on day one — the AI calls are the variable cost, and cached embeddings are never regenerated. |

**Architecture — how the AI part actually works**

This is the section worth understanding properly, because it is the part he will be asked about.

1\. POST /items          API writes the Item row to Postgres,  
                        uploads images to Blob Storage,  
                        enqueues { itemId } on a Storage Queue,  
                        returns 201 immediately.  
   
2\. Queue-triggered      builds a text document from title \+ type \+ conflict \+  
   Azure Function       unit \+ maker \+ marks \+ story body,  
                        calls text-embedding-3-small  \-\> vector(1536),  
                        calls Vision vectorizeImage   \-\> vector(1024),  
                        upserts the ItemEmbedding row.  
   
3\. Related items        SELECT i.\* FROM items i  
                        JOIN item\_embeddings e ON e.item\_id \= i.id  
                        WHERE i.id \<\> @id AND \<visibility predicate\>  
                        ORDER BY e.text\_vector \<=\> @queryVector  
                        LIMIT 10;  
   
4\. Hybrid ranking       score \= w1 \* textSimilarity \+ w2 \* imageSimilarity  
                        (start at 0.7 / 0.3, then tune against labels)

**Why the embeddings are generated asynchronously**

Because an embedding call takes a second or two, depends on a third-party service, and can fail. Doing it inside the POST couples saving a treasured object to the availability of someone else’s API, and makes the upload feel broken when that API is slow. Pushing it onto a queue means the save is fast and durable, a failure is a retry rather than a lost item, and the item page degrades gracefully by simply not showing a related section yet. That reasoning — not the fact that he used a queue — is the answer an interviewer is listening for.

**Evaluate the search instead of just shipping it**

In week 16, before calling the AI work done: pick twenty items, hand-label which other items genuinely belong as related, then measure precision at five for text-only, image-only, and blended ranking. Write the three numbers in the README. This is what converts “I added AI to my project” into “I built a retrieval system and measured it,” and it is the same instinct his AMAXST bullet already shows with the ROC-AUC and the time-based validation split. Most candidates cannot do this. He demonstrably can.

**Wireframes**

A clickable low-fidelity wireframe set accompanies this plan covering the nine screens below. Work from it in week 2, and cut any element that does not serve a Must story before writing a line of markup — deleting a wireframe box costs nothing, deleting a built feature costs a week.

* **Sign-up and sign-in** — email and password, link to 2FA enrollment

* **Two-factor enrollment** — QR code, manual key fallback, verification field, recovery codes displayed once

* **Two-factor challenge** — 6-digit entry, "use a recovery code instead" path

* **My collection** — grid of items with filter rail (conflict, era, nation, branch, type) and search

* **Add / edit item** — attribute form, multi-image dropzone, primary-image selector, visibility control

* **Item detail** — image gallery, attribute table, story body, related items row, visually similar row, comment thread

* **Story editor and story page** — long-form writing attached to an item or standalone

* **Public collector profile** — public items, published stories, follow button

* **Moderator queue** — reported and auto-flagged content with approve, hide, and remove actions

**Schedule — four hours a week**

Twenty-six working weeks, with a gap over the winter break between weeks 12 and 13\. Each row is one four-hour sitting; if a week is lost, push the row rather than compressing two into one.

| Wk | Week of | Four hours spent on |
| :---- | :---- | :---- |
| 1 | Sep 21 | Repo, solution scaffold, README with the pitch. GitHub Actions running build \+ tests on every push. Do CI first — it is trivial while the project is empty and painful later. |
| 2 | Sep 28 | Review the wireframes and cut anything not in the Must list. EF Core entities for the data model below; first migration; Postgres running locally in Docker. |
| 3 | Oct 5 | ASP.NET Core Identity wired in. Register and log in working locally against Postgres. |
| 4 | Oct 12 | TOTP enrollment: generate the shared key, render the QR code, verify the first 6-digit code, flip TwoFactorEnabled. |
| 5 | Oct 19 | Recovery codes, the 2FA challenge on login, lockout after repeated failures. Tests for all of it. MILESTONE: the security story is complete and demonstrable. |
| 6 | Oct 26 | Item CRUD endpoints with validation and ownership checks. |
| 7 | Nov 2 | Blazor pages: item create/edit form, item detail, my-collection grid. |
| 8 | Nov 9 | Blob Storage upload, multiple images per item, primary image, thumbnails. |
| 9 | Nov 16 | Stories attached to items, markdown rendering, integration tests against a real Postgres container. |
| 10 | Nov 23 | Provision Azure: App Service, Postgres, Blob, Key Vault, Managed Identity. Continuous deployment from main. |
| 11 | Nov 30 | Deploy, smoke test, seed 10–15 real pieces from his own collection, screenshots, README rewritten properly. MILESTONE: live URL. This is the one that goes on the resume and in applications. |
| 12 | Dec 7 | pgvector extension enabled, ItemEmbedding table, migration. |
| 13 | Jan 11 | Azure Function on a queue trigger generating text embeddings when an item or story is saved. |
| 14 | Jan 18 | "Related items" — cosine-distance query with a visibility filter, plus the section on the item page. |
| 15 | Jan 25 | Image embeddings and a "visually similar" row. |
| 16 | Feb 1 | Hybrid ranking: blend text and image scores, then MEASURE it — see the evaluation note below. MILESTONE: AI discovery working and evaluated. |
| 17–18 | Feb 8 | Comments with threading, and the authorization rules that go with them. |
| 19 | Feb 22 | Per-item visibility and public collector profiles. |
| 20 | Mar 1 | Reporting flow and the moderator queue. |
| 21 | Mar 8 | Content Safety screening on new text and images before they go public. |
| 22 | Mar 15 | Playwright end-to-end tests over the critical paths. |
| 23–26 | Mar 22 – Apr 12 | Application Insights and structured logging; performance pass (HNSW index, pagination, CDN); accessibility and mobile layout; architecture diagram, demo video, final README. MILESTONE: portfolio-grade. |

**Testing strategy**

His resume shows eleven months of professional .NET work and not one word about testing, which the review flagged as a keyword loss rather than a skill gap. This project fixes that on the page and in fact.

* **Unit tests — xUnit with FluentAssertions.** Pure logic with no I/O: the visibility predicate, comment threading depth limits, the function that assembles embedding input text, and the hybrid ranking blend. Fast enough to run on every save.

* **Integration tests — Testcontainers for .NET.** A real Postgres container per test run, plus Azurite for blobs. Assert that migrations apply cleanly from empty, that EF Core queries return what he thinks, and that a seeded vector fixture comes back in the expected order. Testing pgvector ordering against a real database is the only way to know it works.

* **Authentication tests deserve their own bullet.** Every acceptance criterion on A2 and A3 becomes a test: enrollment, wrong code rejected, right code accepted, recovery code single-use, lockout after repeated failure. These are the tests an interviewer will most respect, because most candidates have never written one.

* **End-to-end — Playwright.** One happy path (register, enable 2FA, log in with a code, create an item with images, see related items, comment) and two failure paths (wrong 2FA code, oversized upload). Run nightly rather than on every push.

* **Fake the paid APIs — the most important testing decision here.** Put Azure OpenAI and Azure AI Vision behind interfaces (IEmbeddingService, IImageVectorizer) and inject a deterministic fake in tests that returns fixed vectors. Tests then never call a paid service, never flake on the network, and never cost money in CI. Without this, the test suite is unrunnable in a pipeline — with it, the pipeline is free.

* **The CI gate.** Build plus unit plus integration on every pull request; end-to-end nightly; deploy on merge to main. Do not chase a coverage percentage — cover authentication, authorization, and ranking, and leave the getters alone.

**Code structure**

The target layout — but read the note underneath it before creating six projects on day one.

Militaria.sln  
  src/  
    Militaria.Domain/          entities, value objects, no dependencies  
    Militaria.Application/     use cases, interfaces, DTOs  
    Militaria.Infrastructure/  EF Core, Postgres, Blob, OpenAI \+ Vision clients  
    Militaria.Api/             ASP.NET Core Web API \+ Identity  
    Militaria.Web/             Blazor Web App  
    Militaria.Functions/       queue-triggered embedding worker  
  tests/  
    Militaria.Domain.Tests/  
    Militaria.Application.Tests/  
    Militaria.Integration.Tests/    Testcontainers  
    Militaria.E2E.Tests/            Playwright  
  infra/                       Bicep templates  
  docs/                        ADRs, architecture diagram, wireframes  
  .github/workflows/           ci.yml, cd.yml

**Start with three projects, not ten.** Domain, one combined Api-plus-Web, and one test project. Split them out when the coupling actually hurts. Over-architecting a solo project is the most common way a four-hour-a-week plan dies in month two — he will spend three weeks on project references and have nothing to show. The layout above is the destination, not the starting line.

**Write five architecture decision records**

One page each in docs/, written when he makes the call: Postgres over MySQL; asynchronous embeddings over inline; Identity with TOTP over Entra External ID; pgvector over a dedicated vector database; Blazor over React. They cost twenty minutes each and they are the single best interview preparation in this plan — when someone asks why he chose something, he will have already written the answer down.

**Risks and cut lines**

* **Scope creep is the project killer, not difficulty.** The cut line is explicit: if week 11 is at risk, drop Phase 5 entirely and ship a single-user catalogue with AI discovery. A narrow thing that works beats a broad thing that does not.

* **Cloud cost.** Burstable Postgres, Basic App Service, and Blob Storage run a few dollars a month; the AI calls are the variable. Budget alert at \$25 on day one, cache every embedding, and never regenerate one.

* **Content and legal exposure.** A short written content policy before the site goes public, automated screening, and a moderation queue. And he should only seed with photographs he owns — other collectors’ images need permission, which is also the provenance discipline the subject deserves.

* **The winter gap.** Four weeks off between weeks 12 and 13 is where momentum dies. Before the break, leave a written note in the repo saying exactly what the next sitting does.

**Resume bullets this produces**

*Fill the brackets from the running system. Nothing goes on the resume before it is deployed and working.*

* “Built and deployed a full-stack collection-management platform (ASP.NET Core, Blazor, PostgreSQL, Azure) with multi-factor authentication via TOTP authenticator apps, recovery codes, and account lockout.”

* “Implemented semantic search over \[N\] catalogued items using Azure OpenAI text embeddings and Azure AI Vision image embeddings stored in pgvector; blended text and image similarity and raised precision@5 from \[X\] to \[Y\] against a hand-labeled set.”

* “Moved embedding generation onto a queue-triggered Azure Function so uploads stayed fast and survived third-party API failures, cutting item-save latency from \[X\] to \[Y\].”

* “Stood up CI/CD in GitHub Actions running unit and Testcontainers-backed integration tests on every pull request, with Playwright end-to-end coverage of authentication and upload paths.”

* “Designed role-based authorization and per-item visibility for a multi-user community with content reporting, a moderation queue, and automated screening via Azure AI Content Safety.”

**The first sitting**

Week one, four hours, in this order, so that momentum exists before motivation is tested: create the repository; write the README with the one-line pitch and the nine screen names; scaffold the solution with three projects; write one trivial passing unit test; add the GitHub Actions workflow that builds and runs it; push and watch the green check appear. Ending the first sitting with a passing pipeline on a public repository is worth more than ending it with a half-built entity model.