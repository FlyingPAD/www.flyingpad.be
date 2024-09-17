import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditLinkCategoryComponent } from './edit-link-category.component';

describe('EditLinkCategoryComponent', () => {
  let component: EditLinkCategoryComponent;
  let fixture: ComponentFixture<EditLinkCategoryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [EditLinkCategoryComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(EditLinkCategoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
