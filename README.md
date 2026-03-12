# NNPTUD - Quy trinh Git cho 2 nguoi (A/B)

## 1) Yeu cau de bai

- Dung template floral: `https://files.all-free-download.com/downloadfiles/graphic/graphic_7/floral_design_template_6890867.zip`
- Lam viec 2 may: A va B.
- Moi ben it nhat 5 commit.
- Moi commit it nhat 5 dong code.
- Tao 2 conflict va xu ly dung quy trinh.
- Chu yeu cham phan giao dien + CSS.

## 2) Rule nhanh (giong git mau)

- Khong code truc tiep tren `main`.
- Khong code truc tiep tren `dev`.
- Moi task la 1 nhanh con tao tu `dev`.

Luong nhanh:

```text
main
  -> dev
      -> feature/floral-ui
```

## 3) Lenh khoi tao (lan dau)

### May A

```bash
git clone https://github.com/phuoc47/NNPTUD.git
cd NNPTUD
git checkout -b dev
git push -u origin dev
git checkout -b feature/floral-ui
git push -u origin feature/floral-ui
```

### May B

```bash
git clone https://github.com/phuoc47/NNPTUD.git
cd NNPTUD
git fetch origin
git checkout -b dev origin/dev
git checkout -b feature/floral-ui origin/feature/floral-ui
```

## 4) Quy trinh lam viec chung

Truoc moi lan sua code:

```bash
git checkout feature/floral-ui
git pull --rebase origin feature/floral-ui
```

Sau khi sua xong:

```bash
git add .
git commit -m "A1: mo ta viec da lam"
git push origin feature/floral-ui
```

Neu push bao conflict:

```bash
git pull --rebase origin feature/floral-ui
# sua conflict trong file
git add .
git rebase --continue
git push origin feature/floral-ui
```

## 5) Chi tiet tung buoc de 2 ban phoi hop

Nhanh lam viec chung: `feature/floral-ui`

### Buoc 1 - A

- Lay project ve: checkout nhanh `feature/floral-ui`, pull moi nhat.
- Viec: tao khung ban dau (`index.html`, `css/style.css`, thu muc `images`), copy asset tu template.
- Git: commit `A1` va push.

### Buoc 2 - B

- Lay project ve: pull nhanh `feature/floral-ui`.
- Viec: dung `header` + `nav` theo template.
- Git: commit `B1` va push.

### Buoc 3 - A

- Lay project ve: pull nhanh `feature/floral-ui`.
- Viec: dung `hero section` (title, subtitle, button).
- Git: commit `A2` va push.

### Buoc 4 - B

- Lay project ve: pull nhanh `feature/floral-ui`.
- Viec: dung block `services/features`.
- Git: commit `B2` va push.

### Buoc 5 - A

- Lay project ve: pull nhanh `feature/floral-ui`.
- Viec: dung block `gallery/portfolio`.
- Git: commit `A3` va push.

### Buoc 6 - B (tao Conflict 1)

- Lay project ve: KHONG pull ngay, sua truc tiep cung doan `hero title` ma A vua sua.
- Viec: doi text `hero title` + chinh css class `.hero-title`.
- Git: commit `B3`, push (se de tao conflict neu A da push truoc).
- Neu conflict: pull --rebase -> sua conflict marker -> add -> rebase --continue -> push.

### Buoc 7 - A

- Lay project ve: pull nhanh `feature/floral-ui`.
- Viec: dung block `contact + footer`.
- Git: commit `A4` va push.

### Buoc 8 - B

- Lay project ve: pull nhanh `feature/floral-ui`.
- Viec: responsive css cho tablet/mobile.
- Git: commit `B4` va push.

### Buoc 9 - A (tao Conflict 2)

- Lay project ve: KHONG pull ngay, sua cung file css ma B vua sua (`css/style.css`), cung class `.hero` hoac bien mau.
- Viec: doi spacing/mau/font khu vuc hero.
- Git: commit `A5`, push (se de tao conflict lan 2).
- Neu conflict: pull --rebase -> sua conflict marker -> add -> rebase --continue -> push.

### Buoc 10 - B

- Lay project ve: pull nhanh `feature/floral-ui`.
- Viec: ra soat giao dien, fix loi css nho, dam bao chay dung template.
- Git: commit `B5` va push.

## 6) Ket thuc va nop bai

1. Tao Pull Request: `feature/floral-ui` -> `dev`.
2. Merge vao `dev`.
3. Neu giang vien yeu cau, tao PR tiep `dev` -> `main`.

## 7) Mau commit message

- A: `A1`, `A2`, `A3`, `A4`, `A5`
- B: `B1`, `B2`, `B3`, `B4`, `B5`

Vi du:

- `A1: init project and import floral assets`
- `B1: build header and navigation from template`

## 8) Checklist truoc khi nop

- [ ] A co toi thieu 5 commit.
- [ ] B co toi thieu 5 commit.
- [ ] Moi commit >= 5 dong code.
- [ ] Co 2 conflict da xu ly thanh cong.
- [ ] Khong ai commit truc tiep len `main`.
- [ ] UI + CSS bam sat template floral.
