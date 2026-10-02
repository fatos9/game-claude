# Story 006: Beş el yapımı bölüm

> **Epic**: firlat-bahcesi
> **Status**: Ready
> **Layer**: Feature
> **Type**: Config/Data
> **Estimate**: —
> **Manifest Version**: N/A (minimal — no control manifest)
> **Last Updated**: —

## Context

**GDD**: `design/game-brief.md`
**Requirement**: Brief MVP feature 6

**ADR Governing Implementation**: N/A (minimal — no ADRs)
**ADR Decision Summary**: N/A (minimal — no ADRs)
**ADR Version**: N/A (minimal — no ADRs)

**Engine**: Unity 6.3 LTS | **Risk**: HIGH
**Engine Notes**: none (no ADR engine-compatibility analysis at minimal)

**Control Manifest Rules (this layer)**: N/A (minimal — no control manifest)

---

## Acceptance Criteria

*From `design/game-brief.md` (Player goal & fail state + MVP feature 6), scoped to this story:*

- [ ] Bölüm verisi (tuğla yerleşimi, atış hakkı, zemin sırası, yıldız eşikleri) kod dışında bir veri formatında tutulur.
- [ ] 5 bölüm oyunda yüklenebilir ve oynanabilir.
- [ ] Zorluk bölüm 1'den 5'e kademeli artar.
- [ ] Her bölüm, verilen atış hakkıyla kazanılabilir (en az bir kez elle denendi).
- [ ] Bölümler arası geçiş veri tabanlı çalışır; yeni bölüm eklemek kod değişikliği gerektirmez.

---

## Implementation Notes

- ScriptableObject veya JSON; küçük proje için ScriptableObject önerilir.

---

## Out of Scope

*Handled by neighbouring stories:*

- Story 005: Değişen zemin şekli
- Story 007: Ana menü ve bölüm seçimi

---

## QA Test Cases

*N/A — no qa-lead specs at this tier; implement against the Acceptance Criteria above*

---

## Test Evidence

**Story Type**: Config/Data
**Required evidence**: Smoke check geçişi (production/qa/smoke-*.md).

**Status**: [ ] Not yet created

---

## Dependencies

- Depends on: Story 005 DONE
- Unlocks: Story 007
