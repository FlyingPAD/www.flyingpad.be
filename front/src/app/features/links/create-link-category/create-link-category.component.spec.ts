import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateLinkCategoryComponent } from './create-link-category.component';

describe('CreateLinkCategoryComponent', () => {
  let component: CreateLinkCategoryComponent;
  let fixture: ComponentFixture<CreateLinkCategoryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [CreateLinkCategoryComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(CreateLinkCategoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
