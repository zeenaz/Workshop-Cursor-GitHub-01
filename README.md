# Unity 2D Platformer Demo

A simple 2D platformer demo built with Unity, designed to help beginners learn Unity basics, Cursor IDE, and GitHub integration.

## Project Overview

This is a minimal demo featuring:
- A single player character with basic movement controls
- One demo scene with a ground platform
- A simple player controller script

### Features
- Left/Right movement (A/D or Arrow keys)
- Jumping (Spacebar)
- Sprite flipping based on movement direction
- Basic physics-based movement

## Documentation

The project includes comprehensive documentation in the `Documentation` folder:

- [Development Log](Documentation/DevelopmentLog.md) - Daily development updates and progress tracking
- [Game Concept Design](Documentation/GameConceptDesign.md) - Game design document and vision
- [Technical Design](Documentation/TechnicalDesign.md) - Technical specifications and architecture
- [Naming Conventions](Documentation/NamingConventions.md) - Asset and code naming standards

## Setup Instructions

1. **Unity Setup**
   - Open the project in Unity Hub
   - Make sure you have Unity 2D template installed
   - Open the demo scene

2. **Player Setup**
   - The player GameObject should have:
     - SpriteRenderer component
     - Rigidbody2D component (set to Dynamic)
     - BoxCollider2D component
     - PlayerController script attached

3. **Ground Setup**
   - Create a ground GameObject
   - Add BoxCollider2D component
   - Tag it as "Ground"

## Controls
- **Move Left**: A key or Left Arrow
- **Move Right**: D key or Right Arrow
- **Jump**: Spacebar

## Learning Objectives
This project serves as a starting point for:
- Understanding Unity's 2D physics system
- Learning basic C# scripting in Unity
- Getting familiar with Cursor IDE
- Basic GitHub workflow

## Project Structure
```
Assets/
├── Scripts/
│   └── PlayerController.cs    # Main player movement script
└── Scenes/
    └── Demo Scene             # Main demo scene

Documentation/
├── DevelopmentLog.md          # Daily development updates
├── GameConceptDesign.md       # Game design document
├── TechnicalDesign.md         # Technical specifications
└── NamingConventions.md       # Asset naming standards
```

## Getting Started
1. Clone this repository
2. Open the project in Unity Hub
3. Open the demo scene
4. Press Play to test the controls

## Requirements
- Unity 2022.3 or later
- Unity 2D template
- Cursor IDE (recommended)
- Basic understanding of Git/GitHub

## Contributing
Feel free to fork this project and experiment with:
- Adding new features
- Modifying movement parameters
- Creating new scenes
- Adding animations

## License
This project is open source and available under the MIT License.

---

# Unity 2D 平台游戏演示 🎮

这是一个用 Unity 制作的简单 2D 平台游戏演示，专门为想要学习 Unity 基础、Cursor IDE 和 GitHub 的同学们设计！🚀

## 项目简介 🎯

这是一个超级简单的演示项目，包含：
- 一个可以移动的玩家角色 🧙‍♂️
- 一个包含地面平台的演示场景 🌍
- 一个简单的玩家控制脚本 💻

### 功能特点 ✨
- 左右移动（A/D 或方向键）
- 跳跃（空格键）
- 角色会根据移动方向自动转向
- 基于物理的移动系统

## 文档 📚

项目包含完整的文档，位于 `Documentation` 文件夹：

- [开发日志](Documentation/DevelopmentLog.md) - 每日开发更新和进度追踪
- [游戏概念设计](Documentation/GameConceptDesign.md) - 游戏设计文档和愿景
- [技术设计](Documentation/TechnicalDesign.md) - 技术规格和架构
- [命名规范](Documentation/NamingConventions.md) - 资源和代码命名标准

## 设置说明 🛠️

1. **Unity 设置**
   - 在 Unity Hub 中打开项目
   - 确保安装了 Unity 2D 模板
   - 打开演示场景

2. **玩家设置**
   - 玩家游戏对象需要包含：
     - SpriteRenderer 组件（显示角色）
     - Rigidbody2D 组件（设置为 Dynamic）
     - BoxCollider2D 组件（碰撞检测）
     - PlayerController 脚本

3. **地面设置**
   - 创建地面游戏对象
   - 添加 BoxCollider2D 组件
   - 将其标签设置为 "Ground"

## 操作方式 🎮
- **向左移动**：A 键或左方向键
- **向右移动**：D 键或右方向键
- **跳跃**：空格键

## 学习目标 📚
这个项目可以帮助你：
- 理解 Unity 的 2D 物理系统
- 学习 Unity 中的 C# 脚本编写
- 熟悉 Cursor IDE 的使用
- 掌握基本的 GitHub 工作流程

## 项目结构 📁
```
Assets/
├── Scripts/
│   └── PlayerController.cs    # 玩家移动控制脚本
└── Scenes/
    └── Demo Scene             # 演示场景

Documentation/
├── DevelopmentLog.md          # 每日开发更新
├── GameConceptDesign.md       # 游戏设计文档
├── TechnicalDesign.md         # 技术规格
└── NamingConventions.md       # 资源命名规范
```

## 开始使用 🚀
1. 克隆这个仓库
2. 在 Unity Hub 中打开项目
3. 打开演示场景
4. 点击播放按钮测试控制

## 环境要求 ⚙️
- Unity 2022.3 或更高版本
- Unity 2D 模板
- Cursor IDE（推荐使用）
- 基本的 Git/GitHub 知识

## 参与贡献 🤝
欢迎同学们来参与这个项目！你可以：
- 添加新功能
- 修改移动参数
- 创建新场景
- 添加动画效果

## 许可证 🫡
本项目采用 MIT 许可证开源。



