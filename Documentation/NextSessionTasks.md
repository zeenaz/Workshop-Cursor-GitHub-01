# Next Session Tasks

## UI Setup
1. Create UI Canvas
   - Right-click in Hierarchy > UI > Canvas
   - This will create Canvas and EventSystem

2. Create Health Display
   - Right-click on Canvas > UI > Text - TextMeshPro
   - Name it "HealthText"
   - Position in top-left corner
   - Set text to "Health: 3/3"
   - Set color to be visible (white on dark background or vice versa)

3. Connect UI to PlayerController
   - Select Player GameObject
   - In PlayerController component, drag HealthText to "Health Text" field

## Game State Management
1. Verify GameStateManager setup
   - Check if GameStateManager GameObject exists in scene
   - Verify GameStateManager script is attached
   - Ensure GameObject is active

2. Create UIManager
   - Create empty GameObject named "UIManager"
   - Add UIManager script to it
   - Set up UI panels in Inspector:
     - Main Menu Panel
     - Game UI Panel
     - Pause Menu Panel
     - Game Over Panel

## Enemy Setup
1. Verify Enemy GameObject
   - Check if tag is set to "Enemy"
   - Verify EnemyController script is attached
   - Check Rigidbody2D component settings:
     - Body Type: Dynamic
     - Mass: 1
     - Linear Drag: 0
     - Angular Drag: 0.05
     - Gravity Scale: 1
     - Collision Detection: Continuous
     - Interpolate: Interpolate
     - Sleeping Mode: Start Awake
     - Constraints: Freeze Rotation Z

2. Check EnemyController settings
   - Damage value (default: 1)
   - Move Speed (default: 3)
   - Detection Range (default: 5)

## Testing Checklist
1. Run game and verify:
   - Health display shows correct values
   - Enemy moves and follows player
   - Collisions between player and enemy are detected
   - Damage is applied when colliding
   - Health updates in UI
   - Player dies when health reaches 0
   - Game over screen appears
   - Restart functionality works

2. Check Console for debug messages:
   - Initial health message
   - Collision messages
   - Damage messages
   - Death message

## Scene Setup
1. Create MainMenu scene
   - Add UI elements for main menu
   - Add start game button
   - Connect to GameStateManager

2. Add scenes to Build Settings
   - Open Build Settings (File > Build Settings)
   - Add MainMenu scene
   - Add Game scene
   - Set MainMenu as first scene

## Notes
- Make sure to save all scenes before testing
- Test in both Play mode and Build
- Check for any missing references in the Inspector
- Verify all scripts are properly attached to their GameObjects

---

# 下一阶段任务

## UI设置
1. 创建UI画布
   - 在层级窗口中右键 > UI > Canvas
   - 这将创建Canvas和EventSystem

2. 创建生命值显示
   - 在Canvas上右键 > UI > Text - TextMeshPro
   - 命名为"HealthText"
   - 放置在左上角
   - 设置文本为"Health: 3/3"
   - 设置颜色使其可见（深色背景用白色，浅色背景用深色）

3. 连接UI到PlayerController
   - 选择Player游戏对象
   - 在PlayerController组件中，将HealthText拖拽到"Health Text"字段

## 游戏状态管理
1. 验证GameStateManager设置
   - 检查场景中是否存在GameStateManager游戏对象
   - 验证是否附加了GameStateManager脚本
   - 确保游戏对象处于激活状态

2. 创建UIManager
   - 创建名为"UIManager"的空游戏对象
   - 添加UIManager脚本
   - 在Inspector中设置UI面板：
     - 主菜单面板
     - 游戏UI面板
     - 暂停菜单面板
     - 游戏结束面板

## 敌人设置
1. 验证敌人游戏对象
   - 检查标签是否设置为"Enemy"
   - 验证是否附加了EnemyController脚本
   - 检查Rigidbody2D组件设置：
     - 身体类型：Dynamic
     - 质量：1
     - 线性阻力：0
     - 角阻力：0.05
     - 重力比例：1
     - 碰撞检测：Continuous
     - 插值：Interpolate
     - 休眠模式：Start Awake
     - 约束：Freeze Rotation Z

2. 检查EnemyController设置
   - 伤害值（默认：1）
   - 移动速度（默认：3）
   - 检测范围（默认：5）

## 测试清单
1. 运行游戏并验证：
   - 生命值显示正确
   - 敌人移动并跟随玩家
   - 检测到玩家和敌人的碰撞
   - 碰撞时造成伤害
   - UI中生命值更新
   - 生命值为0时玩家死亡
   - 显示游戏结束画面
   - 重启功能正常工作

2. 检查控制台的调试消息：
   - 初始生命值消息
   - 碰撞消息
   - 伤害消息
   - 死亡消息

## 场景设置
1. 创建主菜单场景
   - 添加主菜单UI元素
   - 添加开始游戏按钮
   - 连接到GameStateManager

2. 添加场景到构建设置
   - 打开构建设置（File > Build Settings）
   - 添加主菜单场景
   - 添加游戏场景
   - 设置主菜单为第一个场景

## 注意事项
- 测试前确保保存所有场景
- 在Play模式和Build中都进行测试
- 检查Inspector中是否有缺失的引用
- 验证所有脚本都正确附加到游戏对象上 