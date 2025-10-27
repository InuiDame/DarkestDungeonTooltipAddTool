# DarkestDungeonTooltipAddTool
This window program is suitable for quickly editing tooltips and provides multiple types of tooltip editing.

1. Avoid manually switching the language. The program automatically selects Chinese upon launch based on the system language configuration.

2. After entering a color code, press Enter to insert it into the text. Alternatively, double-click a color within the imported color palette box (requires prior import of a color file). A default "common_colors.txt" is provided in the root directory. To create a custom color dictionary, follow its formatting guidelines.

3. Generated content will be directly inserted into the file. A backup (.bak) file will simultaneously be created, although it serves minimal practical purpose.

4. If the game crashes, first verify whether unescaped % symbols (e.g., %% should replace single %) are the cause. Aside from text overflow errors, this is the most common issue in programs created with this tool.
