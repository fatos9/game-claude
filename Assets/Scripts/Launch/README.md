# Launch scripts (story-001)

Not compiled or run; no Unity project exists in the repo yet.

## Requirements
- Package: Input System (`com.unity.inputsystem`); Project Settings > Player > Active Input Handling = Input System Package (New).
- Orthographic 2D camera tagged MainCamera (or assign it).

## Scene wiring
1. Create a `LaunchSettings` asset (Create > Firlat Bahcesi > Launch Settings); tune max pull, min pull, grab radius, impulse per unit, preview length/mask.
2. Ball GameObject: `Rigidbody2D`, `CircleCollider2D` with zero offset. Assign that collider to the launcher's Ball Collider field: the preview skips it. Trigger colliders are ignored by the preview.
3. Empty GameObject `Launcher` with `BallLauncher`: assign Ball (Rigidbody2D), Settings, Preview, and optionally Camera and Ball Collider.
4. GameObject `Preview` with `LineRenderer` (set material/width) and `TrajectoryPreview`.
5. Story 002 should call `BallLauncher.NotifyBallStopped()` when the ball rests, and may subscribe to `OnBallLaunched`.

## Notes
- The ball is held Kinematic while idle (toggle `_holdBallKinematicWhileIdle`) and switched to Dynamic on launch.
- Press must begin within `GrabRadius` of the ball. Only press + drag is read; hover does nothing. Mouse works in the editor via `Pointer.current`.
- Input System must use Dynamic Update (the default); `wasPressedThisFrame` is read in `Update`.
- An aim sticks to the pointer device that started it. If that device is removed mid-aim the aim is cancelled with no shot.
- Launch speed = impulse / ball mass. Changing the ball's mass in story 002 changes launch power; retune `ImpulsePerUnit` then.
- Mouse is also accepted so the game is testable in the editor; strict touch-only is not enforced.

## UNVERIFIED (no editor, official docs unreachable) — check on first compile
`Pointer.current` / `press.isPressed` / `wasPressedThisFrame` / `position.ReadValue()` / `Pointer.added`;
`Physics2D.CircleCast(origin, radius, dir, ContactFilter2D, RaycastHit2D[], distance)`; `RaycastHit2D.centroid`;
`Rigidbody2D.linearVelocity` and `bodyType`; `AddForce(..., ForceMode2D.Impulse)`.
Reviewed by unity-specialist from memory only; multi-touch behaviour needs a device test.
