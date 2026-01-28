# 🚀 Quick Start Guide

Follow these steps to set up your DSA Mastery repository:

## Step 1: Create the GitHub Repository

1. Go to [GitHub](https://github.com/new)
2. Repository name: `dsa-mastery` (or choose from REPO_NAMES.md)
3. Description: "6-week intensive journey through Data Structures & Algorithms with LeetCode implementations"
4. Choose: Public (to showcase your work)
5. ✅ Add README file: NO (we'll add our own)
6. ✅ Add .gitignore: NO (we have a custom one)
7. ✅ Choose a license: NO (we have MIT license included)
8. Click "Create repository"

## Step 2: Initialize Local Repository

Open your terminal and run:

```bash
# Create project directory
mkdir dsa-mastery
cd dsa-mastery

# Initialize git
git init

# Copy all the files from this download into the dsa-mastery folder
# (README.md, .gitignore, LICENSE, CONTRIBUTING.md, PROBLEM_TEMPLATE.md, setup_structure.sh)

# Make setup script executable (if not already)
chmod +x setup_structure.sh

# Run the setup script to create folder structure
./setup_structure.sh

# Review the created structure
ls -la
```

## Step 3: Personalize Your Repository

Edit the following files:

### README.md
- Replace `[Your Name]` with your actual name
- Update GitHub username links
- Add your LeetCode profile link
- Add your LinkedIn profile
- Set your start date and target completion date

### LICENSE
- Replace `[Your Name]` with your actual name

## Step 4: Initial Commit

```bash
# Add all files
git add .

# Make initial commit
git commit -m "Initial commit: Setup DSA Mastery repository structure"

# Add remote (replace 'yourusername' with your GitHub username)
git remote add origin https://github.com/yourusername/dsa-mastery.git

# Push to GitHub
git branch -M main
git push -u origin main
```

## Step 5: Start Learning!

### Your First Implementation

```bash
# Navigate to arrays folder
cd 01-arrays/implementation

# Create your first implementation
touch dynamic_array.py

# Start coding!
```

### Your First LeetCode Problem

```bash
# Navigate to arrays leetcode folder
cd 01-arrays/leetcode/easy

# Copy the problem template
cp ../../../PROBLEM_TEMPLATE.md two_sum.md

# Start solving!
```

## Step 6: Workflow for Each Problem

1. **Choose a problem** from LeetCode
2. **Copy PROBLEM_TEMPLATE.md** to the appropriate folder
3. **Rename** based on problem name (use lowercase-with-hyphens)
4. **Solve** the problem
5. **Document** your solution thoroughly
6. **Commit** your changes:
   ```bash
   git add .
   git commit -m "Solved: Two Sum (Array - Easy)"
   git push
   ```

## Step 7: Update Progress

Regularly update your README.md progress tracker:

```markdown
| Topic | Implementation | LeetCode Problems | Status |
|-------|---------------|-------------------|--------|
| Arrays | 1/1 | 5/20 | 🔄 In Progress |
```

## Pro Tips

### Daily Routine
1. Start with theory/implementation (morning)
2. Solve 2-3 LeetCode problems (afternoon)
3. Review and document (evening)
4. Commit daily progress

### Commit Message Convention
- `feat: Implement AVL tree rotations`
- `solve: Add Two Sum solution (Easy)`
- `docs: Update progress tracker`
- `refactor: Optimize binary search implementation`
- `test: Add unit tests for linked list`

### Stay Organized
- Complete one topic before moving to next
- Keep README updated
- Write tests for implementations
- Document learnings and patterns
- Link related problems

## Additional Resources Setup

### Create a Resources Folder (Optional)
```bash
mkdir resources
mkdir resources/cheatsheets
mkdir resources/notes
mkdir resources/diagrams
```

### Set Up Testing Environment
```bash
# Create virtual environment
python -m venv venv

# Activate it
source venv/bin/activate  # On Windows: venv\Scripts\activate

# Install testing tools
pip install pytest
pip install pytest-cov

# Create requirements.txt
echo "pytest>=7.4.0" > requirements.txt
echo "pytest-cov>=4.1.0" >> requirements.txt
```

## Troubleshooting

### If push is rejected:
```bash
git pull origin main --rebase
git push origin main
```

### If you need to rename remote:
```bash
git remote rename origin old-origin
git remote add origin [new-url]
```

## Next Steps

1. ✅ Complete repository setup
2. ✅ Personalize all files
3. ✅ Create first commit
4. 📚 Start with Arrays topic
5. 💻 Solve first 5 LeetCode problems
6. 📝 Document everything
7. 🚀 Keep the momentum going!

---

**Remember**: Consistency is key! Commit daily, even if it's just one problem.

Good luck on your DSA mastery journey! 💪

---

**Need Help?**
- Check GitHub's [documentation](https://docs.github.com)
- Review [Git basics](https://git-scm.com/doc)
- Ask questions in the Issues section
