import glob
import shutil
import sys

# Get ending tag
tag = sys.argv[1]
# Find existing projects
pattern = "./**/**(*l*)/"
dir_matches = glob.glob(pattern, recursive=True)
print(f"Found {len(dir_matches)} directory matches for \"{pattern}\".")
# Iterate over each
for dir_match in dir_matches:
    # List directory
    print(f"Processing \"{dir_match}\"")
    # 
    path_input = dir_match
    dir_name = dir_match[:-1] # using this keeps folder structure
    #dir_name = dir_match.split("\\")[-2] # get last dir name, assumes tailing \
    path_output = f"./zip-exports/{dir_name}{tag}"
    #print(f"Input : \"{path_input}\".")
    #print(f"Output: \"{path_output}\".")
    shutil.make_archive(path_output, 'zip', path_input)
print("Complete")