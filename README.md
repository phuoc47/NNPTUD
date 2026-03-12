# NNPTUD - Quy Trinh Lam Bai Nhom (2 Nguoi) Theo Git Mau

## 1) Yeu cau de bai (tu anh giao vien)

- Dung template: `https://files.all-free-download.com/downloadfiles/graphic/graphic_7/floral_design_template_6890867.zip`
- Lam viec 2 ben: `A` va `B` (2 may tinh).
- Moi ben tao it nhat `5 commit`.
- Moi commit phai co it nhat `5 dong code`.
- Tao `2 conflict` va xu ly conflict dung quy trinh Git.
- Duoc phep tao project `Java` / `.NET` / `NodeJS`, nhung thay cham chu yeu phan `giao dien + CSS`.
- Deadline theo de: `3h30`.

## 2) Nhanh Git bat buoc (giong mau)

- `main`: tuyet doi khong code truc tiep.
- `dev`: tao tu `main`, cung khong code truc tiep.
- Moi task la 1 branch rieng tao tu `dev`: `feature/<task-name>`.
- Lam xong task thi tao Pull Request vao `dev`.

So do:

```text
main
  └── dev
       ├── feature/layout-base
       ├── feature/home-sections
       ├── feature/components-css
       └── feature/responsive-fix
```

## 3) Khoi tao lan dau

### May A (nguoi tao nhom)

```bash
git clone https://github.com/phuoc47/NNPTUD.git
cd NNPTUD
git checkout -b dev
git push -u origin dev
```

### May B

```bash
git clone https://github.com/phuoc47/NNPTUD.git
cd NNPTUD
git fetch origin
git checkout -b dev origin/dev
```

## 4) Quy trinh lam viec moi ngay (A/B deu giong nhau)

1. Chuyen vao nhanh dang lam:
   `git checkout feature/<task-name>`
2. Dong bo code moi nhat tu remote:
   `git pull --rebase origin feature/<task-name>`
3. Sua code theo task.
4. Commit (dam bao >= 5 dong):
   `git add . && git commit -m "A1: mo ta task"`
5. Day len remote:
   `git push origin feature/<task-name>`
6. Neu push bi reject/conflict:
   `git pull --rebase origin feature/<task-name>` -> sua conflict -> `git add .` -> `git rebase --continue` -> `git push`.

## 5) Ke hoach 10 commit toi thieu (A:5, B:5)

Template floral nen chia thanh cac phan de de thao tac:

1. `A1`: Tao khung project + import assets (anh, css, fonts).
2. `B1`: Tach header/nav tu template vao file giao dien.
3. `A2`: Dung hero section + tieu de + nut CTA.
4. `B2`: Dung section services/features.
5. `A3`: Dung gallery/portfolio block.
6. `B3`: Dung testimonial/team block.
7. `A4`: Hoan thien footer + contact block.
8. `B4`: Viet responsive CSS cho tablet/mobile.
9. `A5`: Chinh spacing, mau, font, animation nhe.
10. `B5`: Soat lai UI, fix bug CSS, don dep cau truc file.

Moi commit can thay doi co y nghia va >= 5 dong code.

## 6) Cach tao dung 2 conflict (de de chung minh)

### Conflict 1 (HTML)

1. A va B cung sua cung 1 doan trong `index.html` (vi du text trong hero title) tren 2 may khac nhau.
2. A push truoc.
3. B push sau se bi tu choi -> B `pull --rebase` va gap conflict.
4. B sua marker conflict (`<<<<<<<`, `=======`, `>>>>>>>`) -> giu noi dung cuoi cung.
5. B `git add .` -> `git rebase --continue` -> `git push`.

### Conflict 2 (CSS)

1. A va B tiep tuc sua cung mot vung trong `css/style.css` (vi du cung class `.hero` hoac bien mau).
2. Lam lai quy trinh nhu conflict 1 de tao conflict lan 2.

Luu y: conflict nen tao co chu dich, khong pha vo giao dien tong.

## 7) Mau lenh day du cho 1 task

```bash
# Tao nhanh task tu dev
git checkout dev
git pull origin dev
git checkout -b feature/home-sections
git push -u origin feature/home-sections

# Lam viec hang ngay
git checkout feature/home-sections
git pull --rebase origin feature/home-sections
# ... sua code ...
git add .
git commit -m "A2: build hero section from floral template"
git push origin feature/home-sections

# Hoan thanh task -> merge vao dev bang Pull Request
```

## 8) Quy dinh commit message de nop bai de doc

- A dung tien to: `A1`, `A2`, `A3`, `A4`, `A5`
- B dung tien to: `B1`, `B2`, `B3`, `B4`, `B5`
- Vi du:
  - `A1: init project structure and import floral assets`
  - `B1: build header and navigation from template`

## 9) Checklist truoc khi nop

- [ ] Khong co commit truc tiep tren `main`.
- [ ] `dev` nhan code qua Pull Request tu cac `feature/*`.
- [ ] A co it nhat 5 commit.
- [ ] B co it nhat 5 commit.
- [ ] Moi commit >= 5 dong code.
- [ ] Da tao va xu ly thanh cong 2 conflict.
- [ ] Giao dien + CSS chay dung theo template floral.

