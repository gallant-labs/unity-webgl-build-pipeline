# 🏗️ Architecture Overview

This project supports two deployment architectures:

---

## **1. Single-Repository Deployment (Portfolio Demo)**

![Image depicting the workflow for a single-repository deployment](/docs/assets/SingleRepoDeployment.png)

**Key Points:**
- Simplest to maintain  
- Ideal for demos & portfolios  
- No GitHub Secrets required  

---

## **2. Cross-Repository Deployment (Classroom Pattern)**
![Image depicting the workflow for a single-repository deployment](/docs/assets/CrossRepoDeployment.png)

**Why this pattern?**
- Keeps student code private  
- Allows public sharing of playable builds  
- Uses GitHub Secrets for secure repo-to-repo deployment  
- Scales cleanly to 20–30 students  

See full classroom implementation → [classroom-setup.md](classroom-setup.md)

