# Story 002: Top fiziği ve zıplama

> **Epic**: firlat-bahcesi
> **Status**: Ready
> **Layer**: Feature
> **Type**: Logic
> **Estimate**: —
> **Manifest Version**: N/A (minimal — no control manifest)
> **Last Updated**: —

## Context

**GDD**: `design/game-brief.md`
**Requirement**: Brief MVP feature 2

**ADR Governing Implementation**: N/A (minimal — no ADRs)
**ADR Decision Summary**: N/A (minimal — no ADRs)
**ADR Version**: N/A (minimal — no ADRs)

**Engine**: Unity 6.3 LTS | **Risk**: HIGH
**Engine Notes**: none (no ADR engine-compatibility analysis at minimal)

**Control Manifest Rules (this layer)**: N/A (minimal — no control manifest)

---

## Acceptance Criteria

*From `design/game-brief.md` (Player goal & fail state + MVP feature 2), scoped to this story:*

- [ ] Top fırlatıldıktan sonra yerçekimi veya sabit hızla hareket eder (tasarım tercihi ilk prototipte seçilir ve kayda geçer).
- [ ] Duvarlardan yansırken geliş açısı = çıkış açısı (enerji kaybı ayarlanabilir).
- [ ] Zemin ve tuğlalardan zıplama yeterince tutarlıdır (aynı girdi aynı sonucu verir).
- [ ] Top belirli bir hızın altına inince veya oyun alanını terk edince 'atış bitti' olayı yayınlanır.
- [ ] Toplar arası/duvara sıkışma durumu bir zaman aşımıyla çözülür (top sonsuza dek zıplamaz).
- [ ] Fizik ayarları (sekme katsayısı, sürtünme, maks hız) tek yerden ayarlanır.

---

## Implementation Notes

- 2D fizik (Rigidbody2D, PhysicsMaterial2D) kullan; 3D değil.
- Fizik tuning'i Unity 6.3'te Input System ile çakışmamalı; girdi hikaye 001'de.

---

## Out of Scope

*Handled by neighbouring stories:*

- Story 001: Sürükle-bırak fırlatma
- Story 003: Kırılan tuğlalar

---

## QA Test Cases

*N/A — no qa-lead specs at this tier; implement against the Acceptance Criteria above*

---

## Test Evidence

**Story Type**: Logic
**Required evidence**: Testler isteğe bağlı (qa.level minimal).

**Status**: [ ] Not yet created

---

## Dependencies

- Depends on: Story 001 DONE
- Unlocks: Story 003
