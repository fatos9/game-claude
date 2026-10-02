# Story 007: Ana menü ve bölüm seçimi

> **Epic**: firlat-bahcesi
> **Status**: Ready
> **Layer**: Feature
> **Type**: UI
> **Estimate**: —
> **Manifest Version**: N/A (minimal — no control manifest)
> **Last Updated**: —

## Context

**GDD**: `design/game-brief.md`
**Requirement**: Brief MVP feature 7

**ADR Governing Implementation**: N/A (minimal — no ADRs)
**ADR Decision Summary**: N/A (minimal — no ADRs)
**ADR Version**: N/A (minimal — no ADRs)

**Engine**: Unity 6.3 LTS | **Risk**: HIGH
**Engine Notes**: none (no ADR engine-compatibility analysis at minimal)

**Control Manifest Rules (this layer)**: N/A (minimal — no control manifest)

---

## Acceptance Criteria

*From `design/game-brief.md` (Player goal & fail state + MVP feature 7), scoped to this story:*

- [ ] Ana menüde 'Oyna' ve bölüm seçimi gösterilir.
- [ ] Bölüm seçimi 5 bölümü listeler; kilidi açılmamış bölümler seçilemez.
- [ ] Bölüm kazanılınca kayıtlı ilerleme (en yüksek yıldız) yerel olarak saklanır.
- [ ] Oyun içinden menüye dönülebilir.
- [ ] Tüm butonlar dokunmatik için yeterince büyüktür (parmakla rahat basılır).
- [ ] Menü portre yönde farklı ekran oranlarında taşma yapmaz.

---

## Implementation Notes

- Unity UI Toolkit veya UGUI; unity-ui-specialist ile doğrula.
- Kayıt sistemi yalnızca yerel ilerleme için (bulut kaydı kapsam dışı).

---

## Out of Scope

*Handled by neighbouring stories:*

- Story 006: Beş el yapımı bölüm

---

## QA Test Cases

*N/A — no qa-lead specs at this tier; implement against the Acceptance Criteria above*

---

## Test Evidence

**Story Type**: UI
**Required evidence**: Ekran görüntüsü: her ekran için production/qa/evidence/ altında.

**Status**: [ ] Not yet created

---

## Dependencies

- Depends on: Story 006 DONE
- Unlocks: None
