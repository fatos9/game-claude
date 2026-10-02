# Game Brief: Fırlat Bahçesi (çalışma adı)

**One-sentence pitch:** Parmağınla topu geri çekip fırlat, her atışta şekil değiştiren bir bahçede tuğlaları kırarak seviyeyi temizle.

## Core loop
- Nişan al: topu sürükleyip geri çek, bırakınca fırlar.
- Top zıplar ve tuğlaları kırar.
- Atış bitince zemin yeni bir şekle geçer; yeni açıya göre yeniden planla.

## Player goal & fail state — what "working" looks like
- Hedef: sınırlı atışla bölümdeki tüm tuğlaları kırmak (yıldız: az atışla).
- Kayıp: atışlar bitip tuğla kalırsa bölüm başarısız, yeniden dene.

## MVP — what must exist to be the game
- Sürükle-bırak fırlatma (yörünge önizlemeli)
- Top fiziği ve zıplama
- Kırılan tuğlalar
- Atış sayacı ve kazanma/kaybetme
- Değişen zemin şekli (3 farklı şekil)
- 5 el yapımı bölüm
- Basit ana menü ve bölüm seçimi

## Out of scope — not building this
- Çok oyunculu
- Bulut kaydı
- Reklam / satın alma
- Meta-ilerleme
- Yatay/dikey çoklu yön desteği (tek yön)
- Özgün müzik üretimi (hazır asset kullan)

## Build order
1. Fırlatma + fizik (önce bunun eğlenceli olduğunu kanıtla)
2. Tuğla ve kırılma
3. Atış sayacı, kazan/kaybet
4. Zemin şekli değişimi
5. Bölümler
6. Menü

---
**Who it's for / what they feel:** Metroda 2-3 dakikalık oturum isteyen oyuncular; "tam isabet" tatmini.

**Art & audio direction:** Düz renkli, yumuşak pastel vektör görünüm; hafif, tok çarpma sesleri.

**Reference game:** Angry Birds — fırlatma hissi; MVP sadece fırlatma + kırma + zemin değişimini alır, kuş türleri ve yapılar yok.
