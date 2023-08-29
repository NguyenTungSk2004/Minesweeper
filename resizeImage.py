import cv2

# Đọc tấm ảnh từ file
image = cv2.imread('mine.png')

# Thay đổi kích thước của tấm ảnh (image, (width, height))
resized_image = cv2.resize(image, (49, 50))

# Lưu tấm ảnh đã được thay đổi kích thước
cv2.imwrite('boom.png', resized_image)