# 🧪 Local Testing & Single-Repo Deployment

You can test and demo the pipeline using a single repository.

---

## 🔧 GitHub Pages Setup

1. Open **Settings → Pages**
2. Select:
   - **Branch:** `gh-pages`
   - **Folder:** `/`
3. Save

When the workflow completes:
- Your Unity WebGL build appears at  
  `https://<username>.github.io/<repo-name>/`

---

## 🧪 Triggering a Build

You can trigger the workflow by:
- Commit to `main`
- Or click **Run workflow** under the Actions tab

---

## 📦 Notes

- No secrets needed in single-repo mode  
- Great for portfolio demonstrations  
- Perfect for test-driving CI/CD logic  
