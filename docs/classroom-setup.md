# 🎓 Classroom Setup (Private → Public Workflow)

This describes the original real-world implementation for a high school Game Design & Implementation course.

---

## 🔐 Goals

- Students keep their **Unity source code private**
- Builds are published to a **shared showcase website**
- Students do not need to install WebGL locally
- Teacher can automate and standardize build workflow
- Only one website needs to be white-listed for student access

---

## 🏗️ How It Worked

### 1. Each student had:
- A **private Unity repo**
- A GitHub Actions workflow file inside their repo

### 2. The workflow:
- Built the Unity project as WebGL
- Packaged the build artifacts
- Pushed them into a **separate public repository** using:

| Secret | Description |
|--------|-------------|
| `GH_PAT` | PAT allowing workflow to push to public repo |
| `TARGET_REPO` | Name of the public deployment repo |
| `TARGET_OWNER` | GitHub username/org of deployment repo |

### 3. The public build repo:
- Contained subfolders per student project
- Hosted via GitHub Pages
- Acted as a class portfolio/play-test site

---

## 📦 Public Repo Structure Example
class-showcase-site/
├── studentA_project/
├── studentB_project/
├── studentC_project/
└── index.html

---

## 🔧 Benefits

- Protects student IP and privacy  
- Allows easy public sharing  
- Gives students hands-on CI/CD experience  
- Zero install: students only push to GitHub  
- Teacher workload drastically reduced  
