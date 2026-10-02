# Story 005: Değişen zemin şekli

> **Epic**: firlat-bahcesi
> **Status**: Ready
> **Layer**: Feature
> **Type**: Integration
> **Estimate**: —
> **Manifest Version**: N/A (minimal — no control manifest)
> **Last Updated**: —

## Context

**GDD**: `design/game-brief.md`
**Requirement**: Brief MVP feature 5

**ADR Governing Implementation**: N/A (minimal — no ADRs)
**ADR Decision Summary**: N/A (minimal — no ADRs)
**ADR Version**: N/A (minimal — no ADRs)

**Engine**: Unity 6.3 LTS | **Risk**: HIGH
**Engine Notes**: none (no ADR engine-compatibility analysis at minimal)

**Control Manifest Rules (this layer)**: N/A (minimal — no control manifest)

---

## Acceptance Criteria

*From `design/game-brief.md` (Player goal & fail state + MVP feature 5), scoped to this story:*

- [ ] En az 3 farklı zemin şekli tanımlıdır (ör. düz, eğimli, çukurlu).
- [ ] Her atış bittikten sonra zemin bir sonraki şekle geçer.
- [ ] Zemin geçişi sırasında top yoktur; geçiş sonrası fırlatma girdisi tekrar açılır.
- [ ] Zemin şekli sırası bölüm verisinden okunur.
- [ ] Zemin değişimi fizik çarpışmalarını (hikaye 002) bozmaz; yeni şekle göre zıplamalar tutarlıdır.
- [ ] Geçiş kısa (≤1 sn) ve akıcıdır.

---

## Implementation Notes

- Zemin şekilleri PolygonCollider2D/EdgeCollider2D ile veya Sprite şekillendirmeyle; en basit çalışan yöntemi seç.

---

## Out of Scope

*Handled by neighbouring stories:*

- Story 004: Atış sayacı ve kazan/kaybet
- Story 006: Beş el yapımı bölüm

---

## QA Test Cases

*N/A — no qa-lead specs at this tier; implement against the Acceptance Criteria above*

---

## Test Evidence

**Story Type**: Integration
**Required evidence**: Testler isteğe bağlı (qa.level minimal).

**Status**: [ ] Not yet created

---

## Dependencies

- Depends on: Story 004 DONE
- Unlocks: Story 006
