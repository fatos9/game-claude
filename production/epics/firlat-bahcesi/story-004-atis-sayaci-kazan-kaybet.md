# Story 004: Atış sayacı ve kazan/kaybet

> **Epic**: firlat-bahcesi
> **Status**: Ready
> **Layer**: Feature
> **Type**: Logic
> **Estimate**: —
> **Manifest Version**: N/A (minimal — no control manifest)
> **Last Updated**: —

## Context

**GDD**: `design/game-brief.md`
**Requirement**: Brief MVP feature 4

**ADR Governing Implementation**: N/A (minimal — no ADRs)
**ADR Decision Summary**: N/A (minimal — no ADRs)
**ADR Version**: N/A (minimal — no ADRs)

**Engine**: Unity 6.3 LTS | **Risk**: HIGH
**Engine Notes**: none (no ADR engine-compatibility analysis at minimal)

**Control Manifest Rules (this layer)**: N/A (minimal — no control manifest)

---

## Acceptance Criteria

*From `design/game-brief.md` (Player goal & fail state + MVP feature 4), scoped to this story:*

- [ ] Her bölümün sabit bir atış hakkı vardır; fırlatılan her top bir hak harcar.
- [ ] Tüm tuğlalar kırılırsa bölüm kazanılır; kalan atışla yıldız (1–3) hesaplanır.
- [ ] Atış hakkı bitip tuğla kalmışsa bölüm başarısız olur.
- [ ] Kazanma/kaybetme anında girdi kilitlenir ve sonuç ekranı gösterilir.
- [ ] Sonuç ekranından 'yeniden dene' ve 'sonraki bölüm' çalışır.
- [ ] Son atış tuğlayı kırarsa ve atış hakkı 0'a inerse bölüm KAZANILMIŞ sayılır (sınır durumu).

---

## Implementation Notes

- Yıldız eşikleri bölüm verisinde tutulur (hikaye 006).

---

## Out of Scope

*Handled by neighbouring stories:*

- Story 003: Kırılan tuğlalar
- Story 005: Değişen zemin şekli

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

- Depends on: Story 003 DONE
- Unlocks: Story 005
