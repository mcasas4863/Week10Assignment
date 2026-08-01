01_Development.md - Design Document

## General Information
* **Project Name**: Week10Assignment
* **Lead Student Developer**: Martha Casas
* **Course and Assignment**: CS-120 (Week 10 Project)
* **Date Started**: July 27, 2026
* **Language & Framework**: VB.NET

## Project Overview

### Brief
* **Core Goal**: I am setting up an interactive dungeon exploration game that builds on the basic grid structures we studied in earlier course modules.

### User or Player
* **Class Target**: CS-120
* **Gameplay Intent**: Players will navigate a character through a grid-based maze environment. They need to easily understand the simple arrow-key controls and explore the map layout without errors.

### Required Deliverables
* **Prepared Environment**: Workspace is properly configured on GitHub.
* **Completed Development Document**: This architectural plan outlines the system parameters.
* **Asset Manifest**: Tracking graphics like `dungon_bg.jpg` in a clean directory log.

## Story or Context
* **The Scenario**: This small puzzle routine opens up whenever a network technician attempts to run logs on an unverified external node.
* **System Purpose**: It functions as an interactive multi-factor login window. It gives the mainframe time to finish loading its security sweeps and checks while keeping the operator occupied.

## Product Definition
* **Minimum Viable Product**: A baseline runnable application where the window initializes correctly, reads map layout boundaries, handles keyboard inputs, and safely terminates when closed.

## Reference Study and Adaptation

| Item Inspected | Action Planned | Decision Rationale | Follow-up Tasks |
|---|---|---|---|
| Title/Intro Screen | Implement | A main entry frame is required to clean up the startup process. | Build a simple start display layer. |
| Sprite Art / Images | Replace | The starting template textures don't match the cavern theme. | Link up my new background graphics. |
| Basic Controls | Implement | Directional character movement is a core requirement for grading. | Wire up the movement loops. |

## Systems and Screens

### Scene Architecture

| Screen Layer | Input Action | Core System Response | Visual Output |
|---|---|---|---|
| Menu State | Press Spacebar | Switches context to the game loop | Renders active level |
| Defeat State | Press Enter | Wipes current trackers and statistics | Re-loads starting point |
| Map Screen | Move Keys | Changes character grid coordinates | Refreshes avatar frame |

## Information Containers

### Trackers and Global Variables

| Variable Identifier | Data Type | Intended Use | Baseline Value |
|---|---|---|---|
| playerHealth | Integer | Monitors current damage tolerance | 100 |
| currentScore | Integer | Tallies total exploration points | 1546 |
| dungeonGrid | Array | Defines walls and open walking spaces | `[,]` |

## Actions

### Code Methods and Events

| Function or Event | Purpose | Inputs | Result / Output |
|---|---|---|---|
| ComputeCombatDamage() | Lowers life value during events | Damage parameters | Reduces playerHealth |
| HandlePlayerMovement() | Repositions avatar on grid | Arrow key presses | Alters position values |
| CheckWallCollisions() | Restricts walking through borders | Coordinate indexes | Keeps avatar inside walls |

## Environment
* **Required Editor**: Visual Studio Community
* **Framework/Workload**: .NET desktop development SDK
* **Template Type**: Windows Forms Application
* **Testing Hardware**: Windows 11 PC build
* **Verification**: Zero compilation alerts or local path crashes.

## Milestones

| Project Phase | Definition of Done | Target Date | Current Status |
|---|---|---|---|
| Initial Setup | Empty project template is committed online | 07/27/2026 | Completed |
| Asset Staging | Grid variables mapped out with files in place | 07/30/2026 | Completed |
| Core Build | Fully playable game build ready for submission | 08/10/2026 | Scheduled |

## Questions and Decisions

| Date Logged | Problem / Technical Detail | Discovery Source | Solution / Final Action |
|---|---|---|---|
| 07/30/2026 | Do we import modules from prior homework sets? | Criteria documentation | Yes, reuse the verified base classes. |
| 07/30/2026 | How do we record open-source asset details? | Syllabus policies | Log all credits directly inside the `02_Assets_Mainifest.md`. |

## Risks
* **Finding Graphic Assets**: Finding dark dungeon textures with clear, open-use licensing rules can take up too much coding time.
* **Feature Scope Creep**: Trying to add too many complex inventory mechanics before the core movement logic is fully stable and tested.
* **File Path Mistakes**: Simple runtime crashes if the program looks for images in the wrong local folders instead of relative paths.



|
