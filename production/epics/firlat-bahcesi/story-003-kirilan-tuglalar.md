# Story 003: Kırılan tuğlalar

> **Epic**: firlat-bahcesi
> **Status**: Ready
> **Layer**: Feature
> **Type**: Logic
> **Estimate**: —
> **Manifest Version**: N/A (minimal — no control manifest)
> **Last Updated**: —

## Context

**GDD**: `design/game-brief.md`
**Requirement**: Brief MVP feature 3

**ADR Governing Implementation**: N/A (minimal — no ADRs)
**ADR Decision Summary**: N/A (minimal — no ADRs)
**ADR Version**: N/A (minimal — no ADRs)

**Engine**: Unity 6.3 LTS | **Risk**: HIGH
**Engine Notes**: none (no ADR engine-compatibility analysis at minimal)

**Control Manifest Rules (this layer)**: N/A (minimal — no control manifest)

---

## Acceptance Criteria

*From `design/game-brief.md` (Player goal & fail state + MVP feature 3), scoped to this story:*

- [ ] Tuğla sahneye bölüm verisinden yerleştirilir (konum, tür).
- [ ] Top tuğlaya çarpınca tuğla kırılır ve yok olur (basit kırılma efekti).
- [ ] Kalan tuğla sayısı her kırılmada güncellenir ve olay olarak yayınlanır.
- [ ] Dayanıklı tuğla (2 vuruş) en az bir tür olarak desteklenir; hasar sayacı vardır.
- [ ] Kırılan tuğla bir daha çarpışmaz.
- [ ] Tüm tuğlalar kırılınca 'bölüm temizlendi' olayı yayınlanır.

---

## Implementation Notes

- Tuğla prefab'ı tek bir bileşenle (Brick) yönetilir.
- Kırılma görseli basit tutulur; cilası sonraki aşamaya bırak.

---

## Out of Scope

*Handled by neighbouring stories:*

- Story 002: Top fiziği ve zıplama
- Story 004: Atış sayacı ve kazan/kaybet

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

- Depends on: Story 002 DONE
- Unlocks: Story 004
