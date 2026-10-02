# Story 001: Sürükle-bırak fırlatma

> **Epic**: firlat-bahcesi
> **Status**: In Progress
> **Layer**: Feature
> **Type**: Visual/Feel
> **Estimate**: —
> **Manifest Version**: N/A (minimal — no control manifest)
> **Last Updated**: 2026-10-02

## Context

**GDD**: `design/game-brief.md`
**Requirement**: Brief MVP feature 1

**ADR Governing Implementation**: N/A (minimal — no ADRs)
**ADR Decision Summary**: N/A (minimal — no ADRs)
**ADR Version**: N/A (minimal — no ADRs)

**Engine**: Unity 6.3 LTS | **Risk**: HIGH
**Engine Notes**: none (no ADR engine-compatibility analysis at minimal)

**Control Manifest Rules (this layer)**: N/A (minimal — no control manifest)

---

## Acceptance Criteria

*From `design/game-brief.md` (Player goal & fail state + MVP feature 1), scoped to this story:*

- [ ] Topu parmakla sürükleyip geri çekmek, çekme yönünün tersine yörünge önizlemesi gösterir.
- [ ] Çekme mesafesi bir üst sınırla kırpılır; sınır aşılınca önizleme ve güç artmaz.
- [ ] Parmak bırakılınca top, çekme vektörünün tersi yönde ve mesafeyle orantılı güçle fırlar.
- [ ] Çok kısa bir çekme (eşik altı) atış sayılmaz; top yerinde kalır.
- [ ] Top hareket halindeyken yeni sürükleme girdisi yok sayılır.
- [ ] Girdi yalnızca dokunmatikle çalışır; hover'a bağlı etkileşim yoktur.
- [ ] Önizleme ile gerçek fırlatma yönü aynıdır; fırlatma 60 fps'te takılmadan hissedilir.

---

## Implementation Notes

- Yörünge önizlemesi çizgi/noktalarla, ilk zıplamaya kadar gösterilir.
- Güç ve yön hesabı bir ScriptableObject veya serialized alanlardan ayarlanabilir olmalı.

---

## Out of Scope

*Handled by neighbouring stories:*

- Story 002: Top fiziği ve zıplama

---

## QA Test Cases

*N/A — no qa-lead specs at this tier; implement against the Acceptance Criteria above*

---

## Test Evidence

**Story Type**: Visual/Feel
**Required evidence**: Ekran görüntüsü: sürükleme sırasında önizleme + fırlatma anı kaydı.

**Status**: [ ] Not yet created

---

## Dependencies

- Depends on: None
- Unlocks: Story 002
