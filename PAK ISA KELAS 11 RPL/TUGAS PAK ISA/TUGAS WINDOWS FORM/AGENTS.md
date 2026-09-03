# AGENTS.md

Windows Forms app, .NET Framework 4.7.2 (old-style, non-SDK `csproj`). Not a git repo — no history to consult. UI text is Indonesian; keep new UI strings in Indonesian to match.

## Build

- `dotnet build AdminForm.slnx` (verified; requires Windows + .NET Framework targeting pack).
- Solution uses the new XML `.slnx` format — only recent VS/MSBuild supports it; do not introduce a legacy `.sln`.
- No NuGet packages, no tests, no CI.

## Structure

- `AdminForm/` — project root. Each form has a code-behind (`.cs`), a designer file (`.Designer.cs`), and a `.resx`.
- Entry point: `AdminForm/Program.cs` runs `LoginForm` (not `Form1`).
- App flow: `LoginForm` ↔ `RegisterForm`, `LoginForm` → `DashboardForm` (Master Bandara screen) → the four master/status forms. All admin-sidebar navigation goes through `AdminForm/NavigationHelper.cs` (`Open`, `OpenFromDashboard`, `BackToDashboard`, `Logout`) using a `DialogResult` signal convention (`OK` = back to Dashboard, `Abort` = logout) so chained `ShowDialog()` navigation unwinds to the right screen. Do not hand-roll `this.Hide()/ShowDialog()/Close()` chains — that reintroduces the "Master Bandara/Logout land on wrong screen" bug. Buttons missing designer wiring are hooked up in each form's constructor; add new sidebar buttons there too, not in the designer region.
- Auth is a stub: login always succeeds (no validation), register shows a success box with a `// TODO` — no data persistence anywhere.
- `Form1` is dead code: still compiled but nothing navigates to it.
- Designer files hold `InitializeComponent()` in a region marked "do not modify"; VS regenerates them. Make UI changes in the designer, not by hand.
- `logo.png` exists in two places (repo root and `AdminForm/`). `LoginForm`/`RegisterForm` load it via `LoadLogo()`: first from the output dir, then walking up to the repo root. Copy this pattern if a new form shows the logo.
- `obj/`, `bin/`, `.vs/` are build/IDE artifacts.
