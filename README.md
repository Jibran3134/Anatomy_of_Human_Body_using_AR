# Anatomy of Human Body using AR

An Augmented Reality (AR) application developed with Unity for exploring and visualizing human body anatomy using 3D models.

The project uses **Unity** and **Vuforia Engine** to provide an AR-based interactive visualization of human organs and anatomical structures.

---

## 📋 Requirements

Before running the project, install:

* **Unity Hub**
* The **exact Unity Editor version used by this project**
* **Git**
* **Git LFS**

### Recommended

Make sure Git LFS is installed and initialized:

```bash
git lfs install
```

> **Important:** Always use the Unity version specified in:
>
> `ProjectSettings/ProjectVersion.txt`
>
> Using a different Unity version may cause package compatibility or project upgrade issues.

---

## 🚀 Getting the Project

### 1. Clone the repository

Open PowerShell, Command Prompt, or Git Bash and run:

```bash
git clone https://github.com/Jibran3134/Anatomy_of_Human_Body_using_AR.git
```

Then enter the project directory:

```bash
cd Anatomy_of_Human_Body_using_AR
```

### 2. Download Git LFS files

This project contains large 3D models and other assets managed using Git LFS.

Run:

```bash
git lfs install
git lfs pull
```

To verify that the LFS files were downloaded:

```bash
git lfs ls-files
```

You should see the project's large assets listed.

---

## 🎮 Opening the Project in Unity

1. Open **Unity Hub**.
2. Select **Add** → **Add project from disk**.
3. Select the cloned project folder:

```text
Anatomy_of_Human_Body_using_AR
```

4. Open the project using the Unity version specified in:

```text
ProjectSettings/ProjectVersion.txt
```

5. Allow Unity to import and process the project.

### First launch

The first time the project is opened, Unity may take some time to:

* Import assets
* Generate the `Library` folder
* Resolve packages
* Generate temporary files
* Process shaders
* Import 3D models and textures

This is normal.

**Do not interrupt Unity during the initial import.**

---

## 📁 Project Structure

The main project structure is:

```text
Anatomy_of_Human_Body_using_AR/
│
├── Assets/
│   ├── Models/
│   ├── Scenes/
│   ├── Scripts/
│   ├── Materials/
│   └── ...
│
├── Packages/
│
├── ProjectSettings/
│
├── QCAR/
│
├── .gitignore
├── .gitattributes
└── README.md
```

### Important folders

| Folder             | Purpose                                                                     |
| ------------------ | --------------------------------------------------------------------------- |
| `Assets/`          | Unity scenes, scripts, models, textures, materials and other project assets |
| `Packages/`        | Unity package dependencies                                                  |
| `ProjectSettings/` | Unity project configuration                                                 |
| `QCAR/`            | Vuforia-related project resources                                           |
| `.gitattributes`   | Git LFS configuration                                                       |
| `.gitignore`       | Prevents generated Unity files from being committed                         |

---

## 📦 Git LFS

This project uses **Git Large File Storage (Git LFS)** because some assets are too large for normal Git storage.

Examples include:

* 3D anatomical models
* `.obj` files
* Vuforia package files
* Other large binary assets

If the project appears to contain files with very small sizes or Git LFS pointer files instead of the actual assets, run:

```bash
git lfs pull
```

You can also verify LFS status with:

```bash
git lfs ls-files
```

---

## ▶️ Running the Application

After Unity finishes importing the project:

1. Open the required scene from the `Assets` folder.
2. Check the scene configuration.
3. Connect/configure the required AR-supported device.
4. Press **Play** in Unity to test the application.

For an actual AR build, configure the required platform and device settings through:

```text
File → Build Settings
```

and:

```text
Edit → Project Settings
```

depending on the Unity version being used.

---

## 📱 AR / Vuforia Setup

This project uses **Vuforia Engine**.

If Vuforia-related components appear correctly in the project after cloning, no additional package installation should normally be required.

If Unity reports missing Vuforia packages or components:

1. Make sure Git LFS has downloaded all files:

```bash
git lfs pull
```

2. Restart Unity.
3. Allow Unity to re-import the project.
4. Check the Unity Package Manager:

```text
Window → Package Manager
```

5. Verify that the required Vuforia package is available.

Do **not** manually delete or replace Vuforia project files unless necessary.

---

## 🔧 Troubleshooting

### Problem: Models are missing

Run:

```bash
git lfs pull
```

Then restart Unity.

Check:

```bash
git lfs ls-files
```

---

### Problem: Unity says packages are missing

Close Unity and reopen the project using the correct Unity version.

Then allow Unity to resolve the packages specified in:

```text
Packages/manifest.json
```

Do not delete the `Packages` folder.

---

### Problem: Unity asks to upgrade the project

You are probably opening the project with a different Unity version.

Check:

```text
ProjectSettings/ProjectVersion.txt
```

Install and use the specified Unity version whenever possible.

---

### Problem: Project opens but assets are still importing

This is expected on the first launch.

Unity generates several folders locally, including:

```text
Library/
Temp/
obj/
Logs/
UserSettings/
```

These folders are normally excluded from Git and will be recreated automatically by Unity.

Wait for Unity to finish importing before testing the application.

---

### Problem: Git LFS command is not recognized

Install Git LFS and then run:

```bash
git lfs install
```

Verify:

```bash
git lfs --version
```

---

## 🔄 Updating the Project

To get the latest changes from GitHub:

```bash
git pull origin main
```

Then make sure large files are synchronized:

```bash
git lfs pull
```

Open/reopen the project in Unity if necessary.

---

## 💾 Making Changes

After modifying the Unity project:

```bash
git status
```

Review the changed files.

Then:

```bash
git add .
git commit -m "Describe your changes"
git push origin main
```

If you add new large assets, make sure their file types are configured in `.gitattributes` for Git LFS.

---

## ⚠️ Important Git Rules

Do **not** manually commit Unity-generated folders such as:

```text
Library/
Temp/
Logs/
obj/
Build/
Builds/
UserSettings/
```

These are generated locally by Unity.

Always commit the actual project source and configuration:

```text
Assets/
Packages/
ProjectSettings/
```

along with the repository configuration files.

---

## 🧹 Fresh Installation

If you want to recreate the project from scratch:

```bash
git clone https://github.com/Jibran3134/Anatomy_of_Human_Body_using_AR.git
cd Anatomy_of_Human_Body_using_AR
git lfs install
git lfs pull
```

Then open the folder through Unity Hub using the Unity version specified in:

```text
ProjectSettings/ProjectVersion.txt
```

Unity will automatically regenerate its local cache and temporary folders.

---

## ✅ Quick Setup

For someone who already has Git, Git LFS, Unity Hub, and the correct Unity Editor installed:

```bash
git clone https://github.com/Jibran3134/Anatomy_of_Human_Body_using_AR.git
cd Anatomy_of_Human_Body_using_AR
git lfs install
git lfs pull
```

Then:

**Unity Hub → Add → Select `Anatomy_of_Human_Body_using_AR` → Open**

Wait for Unity to finish importing the project, open the required scene, and run the application.

---

## 👨‍💻 Repository

**GitHub:**
https://github.com/Jibran3134/Anatomy_of_Human_Body_using_AR

---

## 📌 Notes

* Do not delete `.gitattributes`.
* Do not remove Git LFS configuration.
* Run `git lfs pull` after cloning.
* Use the Unity version specified by `ProjectSettings/ProjectVersion.txt`.
* The first Unity import can take some time.
* Large assets are intentionally stored using Git LFS.
