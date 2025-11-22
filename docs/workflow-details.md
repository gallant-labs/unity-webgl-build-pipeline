# ⚙️ Workflow Details

This document breaks down the GitHub Actions pipeline step by step.

---

## 🧩 Workflow Summary

1. Checkout repository  
2. Install Unity builder  
3. Build WebGL target  
4. Determine deployment mode  
5. Deploy either:
   - to same-repo `gh-pages` branch, or  
   - to external repo via PAT

---

## 📁 Workflow File: `.github/workflows/build-and-deploy.yml`

A typical workflow includes:

- Trigger configuration (`push`, `workflow_dispatch`)
- Unity build step using game-ci/unity-builder
- Artifact staging
- Deployment logic

Add your actual workflow here if desired.

---

## 🔍 Deployment Mode Logic

### Single-Repo Mode
Triggered when:
- `TARGET_REPO` or `TARGET_OWNER` secrets **are not set**

### Cross-Repo Mode
Triggered when:
- All secrets are present:
  - `GH_PAT`
  - `TARGET_REPO`
  - `TARGET_OWNER`

---

## 📦 Artifact Handling

Build output typically appears under:
(replace with a nicer image)
Build/
└── WebGL/
├── index.html
├── UnityLoader.js
├── build.data
└── build.framework.js

These files are published exactly as GitHub Pages expects.
