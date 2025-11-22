# 🔐 GitHub Secrets Configuration

Deployment configuration relies on GitHub Secrets to avoid hardcoding credentials.

---

## ⭐ Required for Cross-Repo Deployment

| Secret Name | Description |
|-------------|-------------|
| `GH_PAT` | Personal Access Token with `repo` scope |
| `TARGET_OWNER` | GitHub username/org of deployment repo |
| `TARGET_REPO` | Name of deployment repo |

---

## ⭐ Optional / Advanced

| Secret | Purpose |
|--------|---------|
| `UNITY_LICENSE` | Required only for licensed Unity cloud builds |
| `SUBFOLDER` | Optional folder to deploy within the public repo |

---

## 🛠 Creating a Personal Access Token

1. Go to: **Settings → Developer settings → Personal access tokens**
2. Choose **Tokens (classic)** or **Fine-grained PAT**
3. Grant:
   - `repo` (private & public repo access)

4. Add the token to:
   - **Settings → Secrets → Actions**

